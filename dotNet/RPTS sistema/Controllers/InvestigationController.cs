using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.InvestigationDto;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service.IService;
using System.Net.Mime;
using System.Security.Claims;

namespace RPTS_sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestigationController : ControllerBase
    {
        private readonly IInvestigationRepository _investigatonRepo;
        private readonly IUserRepository _userRepo;
        private readonly ICompanyRepository _companyRepo;
        private readonly IInvestigationAdapter _investigationAdapter;
        private readonly ILogger<InvestigationController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConclusionRepository _conlusionRepo;

        public InvestigationController(IInvestigationRepository investigatonRepo, ICompanyRepository companyRepo, IInvestigationAdapter investigationAdapter,
            ILogger<InvestigationController> logger, IHttpContextAccessor httpContextAccessor, IUserRepository userRepo, IConclusionRepository conclusionRepo)
        {
            _investigatonRepo = investigatonRepo;
            _companyRepo = companyRepo;
            _investigationAdapter = investigationAdapter;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _userRepo = userRepo;
            _conlusionRepo = conclusionRepo;
        }


        /// <summary>
        /// Sukuriamas naujas tyrimas
        /// </summary>
        /// <param name="investigationDto"></param>
        /// <param name="updateComplainDto"></param>
        /// <returns></returns>
        /// <response code="201">Created</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost("create")]
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GetInvestigations))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   //     [Authorize]
        public async Task<ActionResult<GetInvestigations>> CreateInvestigation(CreateInvestigation investigationDto)
        {
            //try
            //{
            //    _logger.LogInformation($"{DateTime.Now} Atempt to create investigation");
            //    var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            //    if (currentUserRole != "Investigator" && currentUserRole != "Admin" && currentUserRole != "Director")
            //    {
            //        _logger.LogInformation($"{DateTime.Now} User have no rights to add create investigation");
            //        return BadRequest();
            //    }

                if (investigationDto == null)
                {
                    _logger.LogInformation($"{DateTime.Now} input {investigationDto} not valid");
                    return BadRequest();
                }
                var foundInvestigator = await _userRepo.GetAsync(c => c.Id == investigationDto.InvestigatorId);
                var foundCompany = await _companyRepo.GetAsync(i => i.CompanyId == investigationDto.CompanyId);
                var stage = new InvestigationStage
                {
                    Stage = investigationDto.InvestigationStage,
                    TimeStamp = DateTime.Now,
                };
                if (foundInvestigator == null || foundCompany == null)
                {
                    _logger.LogInformation($"{DateTime.Now} Company or investigator is not found in database");
                    return BadRequest();
                }

                var newInvestigation = new Investigation();
                newInvestigation.Company = foundCompany;
                newInvestigation.LegalBase = investigationDto.LegalBase;
                newInvestigation.StartDate = DateTime.Now;
                newInvestigation.Investigators?.Add(foundInvestigator);
                newInvestigation.Stages?.Add(stage);

                await _investigatonRepo.CreateAsync(newInvestigation);
                return CreatedAtRoute("GetInvestigation", new { id = newInvestigation.InvestigationId }, _investigationAdapter.BindForOneInvestigation(newInvestigation));
            }
        //catch (Exception ex)
        //{
        //    _logger.LogError(ex, $"{DateTime.Now} CreateInvestigator exception error.");
        //    return StatusCode(StatusCodes.Status500InternalServerError);
        //}
        // }

        /// <summary>
        /// Grazina visus tyrimus, atvaizduojant tik dali duomenu
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet("investigations")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetInvestigations>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]

        public async Task<IActionResult> GetAllInvestigations([FromQuery] FilterInvestigationRequest req)
        {
            // try
            //{
            //    _logger.LogInformation($"{DateTime.Now} atempt to get all investigations");
            //  var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            //if (currentUserRole != "Investigator" && currentUserRole != "Admin" && currentUserRole != "Director")
            //  {
            //     _logger.LogInformation($"{DateTime.Now} User have no rights to add get investigations");
            //    return BadRequest();
            //}


            //var investigations = await _investigatonRepo.All();
            var investigations = await _investigatonRepo.All();

            //if (investigations == null)
            //  {
            //      _logger.LogInformation($"{DateTime.Now} Investigations not found");
            //      return NotFound();
            // }

            if (req.CompanyId != null)
                investigations = investigations.Where(x => x.Company.CompanyRegistrationNumber == req.CompanyId).ToList();

            if (req.CompanyName != null)
                investigations = investigations.Where(x => x.Company.CompanyName.Contains(req.CompanyName)).ToList();

            if (req.InvestigatorName != null)
                investigations = investigations.Where(x => x.Investigators.Select(x => x.Name).Contains(req.InvestigatorName)).ToList();

            if (req.InvestigatorLastname != null)
                investigations = investigations.Where(x => x.Investigators.Select(x => x.Lastname).Contains(req.InvestigatorLastname)).ToList();

            if (req.InvestigationConlusion != null)
                investigations = investigations.Where(x => x.Conclusion.Decision.Contains(req.InvestigationConlusion)).ToList();

            if (req.ComsisionDecision != null) 
            investigations = investigations.Where(x => x.CommissionDecision.Contains(req.ComsisionDecision)).ToList();

            if (req.IsCompleted != null && req.IsCompleted == "taip")
                investigations = investigations.Where(x => x.IsCompleted == true).ToList();

            if (req.IsCompleted != null && req.IsCompleted == "ne")
                investigations = investigations.Where(x => x.IsCompleted == false).ToList();

            if (req.IsComplained != null && req.IsComplained == "taip")
                investigations = investigations.Where(x => x.DecisionComplained == true).ToList();

            return Ok(investigations
                .Select(c => _investigationAdapter.Bind(c))
                .ToList());
            }
           // catch (Exception ex)
          //  {
          //      _logger.LogError(ex, $"{DateTime.Now} GetAllInvestigations exception error.");
          //      return StatusCode(StatusCodes.Status500InternalServerError);
           // }
        //}

        /// <summary>
        /// Grazina viena tyrima su pilnai duomenimis
        /// </summary>
        /// <param name="id">imone, tyrimo etapas, tyrimo pradzios laikas, pabaigos laikas, isvada, tyrejas, baudos dydis </param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal server error</response>
        //[Authorize(Roles = "Customer")]
        [HttpGet(("{id}"), Name = "GetInvestigation")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetOneInvestigation))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Consumes("application/json")]
        //[Authorize]
        public async Task<ActionResult<GetOneInvestigation>> GetInvestigationById(int id)
        {
            try
            {
                //_logger.LogInformation($"{DateTime.Now} atempt to get investigation with id {id} ");
                //var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                //if (currentUserRole != "Investigator" && currentUserRole != "Admin" && currentUserRole != "Director")
                //{
                //    _logger.LogInformation($"{DateTime.Now} User have no rights to get investigation data");
                //    return BadRequest();
                //}
                if (id == 0)
                {
                    _logger.LogInformation($"{DateTime.Now} Input {id} is not valid");
                    return BadRequest();
                }
                if (await _investigatonRepo.ExistAsync(x => x.InvestigationId == id) == false)
                {
                    _logger.LogInformation($"{DateTime.Now} Investigation with {id} not found");
                    return NotFound();
                }
                var investigation = await _investigatonRepo.GetById(id);

                var investigationDto = _investigationAdapter.BindForOneInvestigation(investigation);

                return Ok(investigationDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} GetInvestigationById exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("inspection/{inspectionId:int}/conclusions")]
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
       // [Authorize]

        //pasidaryt, kad butu req dto ir updatintu tik tuos laukus ir keistu,
        //kuriuose buvo kazkas ivesta pvz if req.investigatorId != && =! 0 surandam ta tyreja, patikrintam findfirst, ar nera tokio jau prideta ir jeigu nera idedam. foundinvestigation.Add(foundInvestigator)
        public async Task<ActionResult> UpdateInvestigation(int inspectionId, UpdateInvestigation update)
        {
            //  try
            //  {
            //      _logger.LogInformation($"{DateTime.Now} attempt to add conclusion to inspection ");
            //      var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            //      if (currentUserRole != "Investigator" && currentUserRole != "Admin" && currentUserRole != "Director")
            //      {
            //          _logger.LogInformation($"{DateTime.Now} User have no rights to add conclusion to inspection");
            //          return BadRequest();
            //      }


                if (update == null || inspectionId == 0)
                {
                    _logger.LogInformation($"{DateTime.Now} input {inspectionId} Or {update} not valid");
                    return BadRequest();
                }
                var foundInvestigation = await _investigatonRepo.GetById(inspectionId);
                if (foundInvestigation == null)
                {
                    _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                    return NotFound();
                }
            if (update.CommissionDecision != null && update.CommissionDecision != "string")
            {
                foundInvestigation.CommissionDecision = update.CommissionDecision;
            }
            if (update.LegalBase != null && update.LegalBase != "string")
            {
                foundInvestigation.LegalBase = update.LegalBase;
            }
            if (update.ConclusionId != null && update.ConclusionId > 0)
            {
            var foundConclusion = await _conlusionRepo.GetAsync(i => i.ConclusionId == update.ConclusionId);
                if (foundConclusion == null)
                {
                    _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                    return NotFound();
                }
               else
                foundInvestigation.Conclusion = foundConclusion;
                foundInvestigation.EndDate = DateTime.Now;
            }
            if (update.Penalty != null && update.Penalty >= 0 )
            {
                foundInvestigation.Penalty = update.Penalty;

            }
            if (update.DecisionComplained != null && update.DecisionComplained == "taip" || update.DecisionComplained == "ne")
            {
                if(update.DecisionComplained == "taip")
                foundInvestigation.DecisionComplained = true;
                if (update.DecisionComplained == "ne")
                    foundInvestigation.DecisionComplained = false;
            }
            if (update.InvestigationStage != null && update.InvestigationStage != "string")
            {
                var stage = new InvestigationStage
                {
                    Stage = update.InvestigationStage,
                    TimeStamp = DateTime.Now,
                };
                foundInvestigation.Stages.Add(stage);
            }
            if (update.InvestigatorId != null && update.InvestigatorId > 0)
            {
                var foundInvestigator = await _userRepo.GetAsync(i => i.Id == update.InvestigatorId);
                if (foundInvestigator == null || foundInvestigation.Investigators.Any(x => x.Id == foundInvestigator.Id))
                {
                    _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                    return BadRequest("Tyrėjas nerastas, arba jau pridėtas");
                }
                      
            else
                foundInvestigation.Investigators.Add(foundInvestigator);
            }

            foundInvestigation.UpdateDate = DateTime.Now;




            //if (foundComplain.Conclusion != null && currentUserRole != "Admin")
            //{
            //    _logger.LogInformation($"{DateTime.Now} inspection already have conclusion");
            //    return BadRequest("Byla jau užbaigta");


            await _investigatonRepo.Update(foundInvestigation);

                return NoContent();
            }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"{DateTime.Now} AddConclusionToInspection exception error.");
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //}
//    }
//}


    }
}
