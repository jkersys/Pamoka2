﻿//using ApiMokymai.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace ApiMokymai.Controllers.P003
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DiController : ControllerBase
//    {
//        private readonly IOperationTransient _operationTransient;
//        private readonly IOperationScoped _operationScoped;
//        private readonly IOperationSingleton _operationSingleton;

//        public DiController(IOperationTransient operationTransient,
//            IOperationScoped operationScoped,
//            IOperationSingleton operationSingleton)
//        {
//            _operationTransient = operationTransient;
//            _operationScoped = operationScoped;
//            _operationSingleton = operationSingleton;
//        }

//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(new
//            {
//                Transient = _operationTransient.GetOperationId(),
//                Scoped = _operationScoped.GetOperationId(),
//                Singleton = _operationSingleton.GetOperationId()
//            });
//        }

//    }
//}