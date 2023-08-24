using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service.IService;
using System.Net.Mime;
using System.Security.Claims;

namespace RPTS_sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepo;
       // private readonly ICompanyAdapter _companyAdapter;
        private readonly ILogger<CompanyController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICompanyAdapter _companyAdapter;

        public CompanyController(ICompanyRepository companyRepo, ILogger<CompanyController> logger, IHttpContextAccessor httpContextAccessor, ICompanyAdapter companyAdapter)
        {
            _companyRepo = companyRepo;
            //_companyAdapter = companyAdapter;
            //_logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _companyAdapter = companyAdapter;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCompany>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Get([FromQuery] FilterComapniesRequest req)
        {
            // _logger.LogInformation("Getting car list with parameters {req}", JsonConvert.SerializeObject(req));

            var entities = await _companyRepo.GetAllAsync(x => x.IsCompanyDeleted == false);
            //var entities = await _companyRepo.GetAllAsync();

            if (req.CompanyName != null )
                entities = entities.Where(x => x.CompanyName.Contains(req.CompanyName)).ToList();

            if (req.CompanyRegistrationNumber != null && req.CompanyRegistrationNumber != 0)
                entities = entities.Where(x => x.CompanyRegistrationNumber == req.CompanyRegistrationNumber).ToList();

            if (req.CompanyFoundDate != null);
                entities = entities.Where(x => x.CompanyFoundDate >= req.CompanyFoundDate).ToList();

            if (req.CompanyCategory != null)
                entities = entities.Where(x => x.CompanyCategory.Contains(req.CompanyCategory)).ToList();

            var model = entities.Select(x => new GetCompany(x)).ToList();

            return Ok(model);
        }

        /// <summary>
        /// sukuriama nauja imone
        /// </summary>
        /// <param name="companyDto"></param>
        /// <returns></returns>
        ///<response code="201">Created</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost("create")]
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GetCompany))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[Authorize]

        public async Task<ActionResult<GetCompany>> CreateCompany([FromBody]CreateCompany companyDto)
        {
            //try
            // {
            //_logger.LogError($"{DateTime.Now} attempt to create new company.");
            // var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            // if (currentUserRole != "Admin" && currentUserRole != "Director" && currentUserRole != "Investigator")
            // {
            //     _logger.LogInformation($"{DateTime.Now} User have no right to create company");
            //     return BadRequest("You have no right to create company");
            //}
            
                if (companyDto == null)
                {
                    _logger.LogError($"{DateTime.Now} input {companyDto} not valid");
                    return BadRequest();
                }

                var createCompany = _companyAdapter.Bind(companyDto);
                var isExist = await _companyRepo.ExistAsync(x => x.CompanyRegistrationNumber == companyDto.CompanyRegistrationNumber);

                if (isExist == true)
                {
                    _logger.LogError($"{DateTime.Now} company with {companyDto.CompanyRegistrationNumber} already exist");
                    return BadRequest("Imone jau yra duomenu bazeje");
                }

                await _companyRepo.CreateAsync(createCompany);
                return CreatedAtRoute("GetCompany", new { id = createCompany.CompanyId }, _companyAdapter.Bind(createCompany));

            }
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, $"{DateTime.Now} CreateCompany exception error.");
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
        //}

        ///// <response code="500">Internal server error</response>
        //[HttpGet("{id:int}", Name = "GetCompany")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCompany))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[Produces("application/json")]
        //[Consumes("application/json")]
        //[Authorize]
        //public async Task<ActionResult<GetCompany>> GetCompanyById(int id)
        //{
        //    try
        //    {
        //        _logger.LogInformation($"{DateTime.Now} attempt to get company with id {id} ");
        //        var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
        //        if (currentUserRole != "Admin" && currentUserRole != "Director" && currentUserRole != "Investigator")
        //        {
        //            _logger.LogInformation($"{DateTime.Now} User have no right to load company {id} data");
        //            return BadRequest("You have no right to load company data");
        //        }
        //        if (id == 0)
        //        {
        //            _logger.LogInformation($"{DateTime.Now} input {id} not valid");
        //            return BadRequest();
        //        }
        //        var company = await _companyRepo.GetAsync(x => x.CompanyId == id);

        //        if (company == null)
        //        {
        //            _logger.LogInformation($"{DateTime.Now}company {id} not found");
        //            return NotFound();
        //        }

        //        var companyDto = _companyAdapter.Bind(company);

        //        return Ok(companyDto);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"{DateTime.Now} GetCompanyById exception error.");
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //}
    }
}
