using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPTS_sistema.Models.DTO.InvestigationDto;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service.IService;
using RPTS_sistema.Models.DTO.ComplainDto;

namespace RPTS_sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        private readonly IInvestigationRepository _investigatonRepo;
        private readonly IUserRepository _userRepo;
        private readonly ICompanyRepository _companyRepo;
        private readonly IInvestigationAdapter _investigationAdapter;
        private readonly ILogger<InvestigationController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConclusionRepository _conlusionRepo;
        private readonly IComplainRepository _complainRepo;
        private readonly IComplainAdapter _complainAdapter;

        public ComplainController(IInvestigationRepository investigatonRepo, ICompanyRepository companyRepo, IInvestigationAdapter investigationAdapter,
            ILogger<InvestigationController> logger, IHttpContextAccessor httpContextAccessor, IUserRepository userRepo, IConclusionRepository conclusionRepo, IComplainRepository complainRepo, IComplainAdapter complainAdapter)
        {
            _investigatonRepo = investigatonRepo;
            _companyRepo = companyRepo;
            _investigationAdapter = investigationAdapter;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _userRepo = userRepo;
            _conlusionRepo = conclusionRepo;
            _complainRepo = complainRepo;
            _complainAdapter = complainAdapter;
        }

        /// <summary>
        /// Sukuriamas naujas tyrimas
        /// </summary>
        /// <param name="complain"></param>
        /// <param name="updateComplainDto"></param>
        /// <returns></returns>
        /// <response code="201">Created</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost("create")]
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GetComplain))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //     [Authorize]
        public async Task<ActionResult<GetComplain>> CreateComplain(CreateComplain complain)
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

            if (complain == null)
            {
                _logger.LogInformation($"{DateTime.Now} input {complain} not valid");
                return BadRequest();
            }
            var foundConclusion = await _conlusionRepo.GetAsync(c => c.ConclusionId == complain.ConclusionId);
            var foundCompany = await _companyRepo.GetAsync(i => i.CompanyId == complain.CompanyId);
            
            if (foundConclusion == null || foundCompany == null)
            {
                _logger.LogInformation($"{DateTime.Now} Company or conclusion is not found in database");
                return BadRequest();
            }

            var newComplain = new Complain();
            newComplain.Company = foundCompany;
            newComplain.Complainant = complain.Complainant;
            newComplain.ComplainDate = complain.ComplainDate;
            newComplain.Description = complain.Description;
            newComplain.Conclusion = foundConclusion;

            await _complainRepo.CreateAsync(newComplain);
            return CreatedAtRoute("GetComplain", new { id = newComplain }, _complainAdapter.BindForOne(newComplain));
        }
        //catch (Exception ex)
        //{
        //    _logger.LogError(ex, $"{DateTime.Now} CreateInvestigator exception error.");
        //    return StatusCode(StatusCodes.Status500InternalServerError);
        //}
        // }

        [HttpGet(("{id}"), Name = "GetComplain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetOneInvestigation))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Consumes("application/json")]
        //[Authorize]
        public async Task<ActionResult<GetOneInvestigation>> GetComplainById(int id)
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
                var investigation = await _investigatonRepo.GetById(id);
                if (investigation == null)
                {
                    _logger.LogInformation($"{DateTime.Now} Complain with {id} not found");
                    return NotFound();
                }

                var investigationDto = _investigationAdapter.BindForOneInvestigation(investigation);

                return Ok(investigationDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} GetComplainById exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


    }
}
