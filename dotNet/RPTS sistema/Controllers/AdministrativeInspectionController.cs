using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.AdministrativeInspectionDto;
using RPTS_sistema.Models.DTO.InvestigationDto;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service.IService;
using System.Security.Claims;

namespace RPTS_sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativeInspectionController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICompanyRepository _companyRepo;
        private readonly IAdministrativeInspectionRepository _adminInspectionRepo;
        private readonly IUserRepository _userRepo;
        private readonly IAdministrativeInspectionAdapter _inspectionAdapter;
        private readonly ILogger<AdministrativeInspectionController> _logger;
        private readonly IConclusionRepository _conclusionRepo;

        public AdministrativeInspectionController(IUserRepository userRepo, IHttpContextAccessor httpContextAccessor,
           IAdministrativeInspectionRepository adminInspectionRepo, ICompanyRepository companyRepo, IAdministrativeInspectionAdapter inspectionAdapter, ILogger<AdministrativeInspectionController> logger, IConclusionRepository conclusionRepo)
        {
            _userRepo = userRepo;
            _httpContextAccessor = httpContextAccessor;
            _adminInspectionRepo = adminInspectionRepo;
            _companyRepo = companyRepo;
            _inspectionAdapter = inspectionAdapter;
            _logger = logger;
            _conclusionRepo = conclusionRepo;
        }


        /// <summary>
        /// sukuriama nauja administracine patikra
        /// </summary>
        /// <param name="inspection"></param>
        /// <returns></returns>
        [HttpPost("inspection/create")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GetOneAdminInspection))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        public async Task<ActionResult<GetOneAdminInspection>> CreateAdministrativeInspection(CreateAdminInspection inspection)
        {
            try
            {
                _logger.LogError($"{DateTime.Now} attempt to create new administrative inspection.");
                _logger.LogInformation($"{DateTime.Now} attempt to create inspection");
                var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                if (currentUserRole != "Admin" && currentUserRole != "Director" && currentUserRole != "Investigator")
                {
                    _logger.LogInformation($"{DateTime.Now} User have no right to create inspections data");
                    return BadRequest("You have no right to delete companies data");
                }

                if (inspection == null)
                {
                    _logger.LogError($"{DateTime.Now} input {inspection} not valid");
                    return BadRequest();
                }
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
                var newAdministrativeInspection = new AdministrativeInspection();

                if (currentUserRole == "Investigator")
                {
                    var user = await _userRepo.GetUserById(currentUserId);
                    //var foundInvestigator = user;
                    var foundCompany = await _companyRepo.GetAsync(i => i.CompanyId == inspection.CompanyId);
                    if (user == null || foundCompany == null)
                    {
                        _logger.LogError($"{DateTime.Now} user is not investigator or company id {inspection.CompanyId} not exist");
                        return BadRequest();
                    }
                    var stage = new InvestigationStage
                    {
                        Stage = inspection.InvestigationStage,
                        TimeStamp = DateTime.Now,
                    };
                    newAdministrativeInspection = new AdministrativeInspection()
                    {
                        StartDate = DateTime.Now,
                        Company = foundCompany,
                    };
                    newAdministrativeInspection.InvestigationStages.Add(stage);
                    newAdministrativeInspection.Investigators.Add(user);
                    await _adminInspectionRepo.CreateAsync(newAdministrativeInspection);

                   // return CreatedAtRoute("GetAdministrativeInspection", new { id = newAdministrativeInspection.AdministrativeInspectionId }, _inspectionAdapter.Bind(newAdministrativeInspection));
                }
                if (currentUserRole == "Admin" || currentUserRole == "Director")
                {
                    var user = await _userRepo.GetUserById(inspection.InvestigatorId);
                    //var foundInvestigator = user;
                    var foundCompany = await _companyRepo.GetAsync(i => i.CompanyId == inspection.CompanyId);
                    if (user == null || foundCompany == null)
                    {
                        _logger.LogError($"{DateTime.Now} user is not investigator or company id {inspection.CompanyId} not exist");
                        return BadRequest();
                    }
                    var stage = new InvestigationStage
                    {
                        Stage = inspection.InvestigationStage,
                        TimeStamp = DateTime.Now,
                    };
                    newAdministrativeInspection = new AdministrativeInspection()
                    {
                        StartDate = DateTime.Now,
                        Company = foundCompany,
                    };
                    newAdministrativeInspection.InvestigationStages.Add(stage);
                    newAdministrativeInspection.Investigators.Add(user);
                    await _adminInspectionRepo.CreateAsync(newAdministrativeInspection);

                    //   return CreatedAtRoute("GetAdministrativeInspection", new { id = newAdministrativeInspection.AdministrativeInspectionId }, _inspectionAdapter.Bind(newAdministrativeInspection));
                }


                return CreatedAtRoute("GetAdministrativeInspection", new { id = newAdministrativeInspection.AdministrativeInspectionId }, _inspectionAdapter.Bind(newAdministrativeInspection));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} CreateAdministrativeInspection exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        /// <summary>
        /// grazina viena administracine patikra su pilnais duomenimis
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal server error</response> 
        //[Authorize(Roles = "Customer")]
        [HttpGet("inspection/{id:int}", Name = "GetAdministrativeInspection")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetOneAdminInspection))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Consumes("application/json")]
        [Authorize]
        public async Task<ActionResult<GetOneAdminInspection>> GetInspectionById(int id)
        {
            try
            {
                _logger.LogInformation($"{DateTime.Now} attempt to get one administrative inspection {id}");
                var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                if (currentUserRole != "Admin" && currentUserRole != "Director" && currentUserRole != "Investigator")
                {
                    _logger.LogInformation($"{DateTime.Now} User have no right to get inspection data");
                    return BadRequest("You have no right to get inspection data");
                }
                if (id == 0)
                {
                    _logger.LogInformation($"{DateTime.Now} input {id} not valid");
                    return BadRequest();
                }
                if (await _adminInspectionRepo.ExistAsync(x => x.AdministrativeInspectionId == id) == false)
                {
                    _logger.LogInformation($"{DateTime.Now} administrative inspection id Nr. {id} not found");
                    return NotFound();
                }
                var inspection = await _adminInspectionRepo.GetById(id);

                var inspectionDto = _inspectionAdapter.BindOneInspection(inspection);

                return Ok(inspectionDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} GetInspectionById exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("inspections")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAdminInspections([FromQuery] FilterInspectionRequest req)
        {
            try
            {
                _logger.LogInformation($"{DateTime.Now} attempt to get all administrative inspections");
                var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
                //if (currentUserRole != "Admin" && currentUserRole != "Director" && currentUserRole != "Investigator")
                //{
                //    _logger.LogInformation($"{DateTime.Now} User have no right to get inspections data");
                //    return BadRequest("You have no right to get inspections data");
                //}
                var inspection = await _adminInspectionRepo.LoggedUserAdministrativeInspecitons();

                if (inspection == null)
                {
                    _logger.LogInformation($"{DateTime.Now} administrative inspections not found");
                    return NotFound();
                }

                if (req.CompanyId != null)
                    inspection = inspection.Where(x => x.Company.CompanyRegistrationNumber == req.CompanyId).ToList();

                if (req.CompanyName != null)
                    inspection = inspection.Where(x => x.Company.CompanyName.Contains(req.CompanyName)).ToList();

                if (req.InvestigatorName != null)
                    inspection = inspection.Where(x => x.Investigators.Any(x => x.Name.Contains(req.InvestigatorName)));

                if (req.InvestigatorLastname != null)
                    inspection = inspection.Where(x => x.Investigators.Any(x => x.Lastname.Contains(req.InvestigatorLastname)));                       
                if (req.Conlusion != null)
                    inspection = inspection.Where(x => x.Conclusion.Decision.Contains(req.Conlusion)).ToList();
                if (req.StartDate != null) 
                inspection = inspection.Where(x => x.StartDate >= req.StartDate).ToList();
                if (req.EndDate != null) 
                inspection = inspection.Where(x => x.EndDate <= req.EndDate).ToList();




                return Ok(inspection
                .Select(c => _inspectionAdapter.Bind(c))
                .ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} GetAdminInspections exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("inspection/{inspectionId:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateInspection(int inspectionId, UpdateAdminInspection update)
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
            var foundInspection = await _adminInspectionRepo.GetById(inspectionId);
            if (foundInspection == null)
            {
                _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                return NotFound();
            }
       
            if (update.ConclusionId != null && update.ConclusionId > 0)
            {
                var foundConclusion = await _conclusionRepo.GetAsync(i => i.ConclusionId == update.ConclusionId);
                if (foundConclusion == null)
                {
                    _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                    return NotFound();
                }
                else
                    foundInspection.Conclusion = foundConclusion;
                foundInspection.EndDate = DateTime.Now;
            }
    
           
            if (update.InvestigationStage != null && update.InvestigationStage != "string")
            {
                var stage = new InvestigationStage
                {
                    Stage = update.InvestigationStage,
                    TimeStamp = DateTime.Now,
                };
                foundInspection.InvestigationStages.Add(stage);
            }
            if (update.InvestigatorId != null && update.InvestigatorId > 0)
            {
                var foundInvestigator = await _userRepo.GetAsync(i => i.Id == update.InvestigatorId);
                if (foundInvestigator == null || foundInspection.Investigators.Any(x => x.Id == foundInvestigator.Id))
                {
                    _logger.LogInformation($"{DateTime.Now} inspection Nr. {inspectionId} not found");
                    return BadRequest("Tyrėjas nerastas, arba jau pridėtas");
                }
                else
                    foundInspection.Investigators.Add(foundInvestigator);
            }

            foundInspection.UpdateDate = DateTime.Now;




            //if (foundComplain.Conclusion != null && currentUserRole != "Admin")
            //{
            //    _logger.LogInformation($"{DateTime.Now} inspection already have conclusion");
            //    return BadRequest("Byla jau užbaigta");


            await _adminInspectionRepo.Update(foundInspection);

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
