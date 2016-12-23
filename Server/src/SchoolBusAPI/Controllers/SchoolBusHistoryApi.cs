/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using SchoolBusAPI.Models;
using SchoolBusAPI.Services;

namespace SchoolBusAPI.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public partial class SchoolBusHistoryApiController : Controller
    {
        private readonly ISchoolBusHistoryApiService _service;

        /// <summary>
        /// Create a controller and set the service
        /// </summary>

        public SchoolBusHistoryApiController(ISchoolBusHistoryApiService service)
        {
            _service = service;
        }
	
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="201">SchoolBusHistories created</response>
        [HttpPost]
        [Route("/api/schoolbushistories/bulk")]
        [SwaggerOperation("SchoolbushistoriesBulkPost")]
        public virtual IActionResult SchoolbushistoriesBulkPost([FromBody] SchoolBusHistory[] body)
        {
            return this._service.SchoolbushistoriesBulkPostAsync(body);
        }
        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/schoolbushistories")]
        [SwaggerOperation("SchoolbushistoriesGet")]
        [SwaggerResponse(200, type: typeof(List<SchoolBusHistory>))]
        public virtual IActionResult SchoolbushistoriesGet()
        { 
            return this._service.SchoolbushistoriesGetAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id">id of SchoolBusHistory to delete</param>
        /// <response code="200">OK</response>
        /// <response code="404">SchoolBusHistory not found</response>
        [HttpDelete]
        [Route("/api/schoolbushistories/{id}")]
        [SwaggerOperation("SchoolbushistoriesIdDelete")]
        public virtual IActionResult SchoolbushistoriesIdDelete([FromRoute]int id)
        {
            return this._service.SchoolbushistoriesIdDeleteAsync(id);
        }
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id">id of SchoolBusHistory to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">SchoolBusHistory not found</response>
        [HttpPut]
        [Route("/api/schoolbushistories/{id}")]
        [SwaggerOperation("SchoolbushistoriesIdPut")]
        [SwaggerResponse(200, type: typeof(SchoolBusHistory))]
        public virtual IActionResult SchoolbushistoriesIdPut([FromRoute]int id, [FromBody]SchoolBusHistory body)
        { 
            return this._service.SchoolbushistoriesIdPutAsync(id, body);
        }
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="201">SchoolBusHistory created</response>
        [HttpPost]
        [Route("/api/schoolbushistories")]
        [SwaggerOperation("SchoolbushistoriesPost")]
        [SwaggerResponse(200, type: typeof(SchoolBusHistory))]
        public virtual IActionResult SchoolbushistoriesPost([FromBody]SchoolBusHistory body)
        { 
            return this._service.SchoolbushistoriesPostAsync(body);
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="id">id of SchoolBusHistory to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">SchoolBusHistory not found</response>
        [HttpGet]
        [Route("/api/schoolbushistories/{id}")]
        [SwaggerOperation("SchoolbushistoriesIdGet")]
        [SwaggerResponse(200, type: typeof(SchoolBusAttachment))]
        public virtual IActionResult SchoolbushistoriesIdGet([FromRoute]int id)
        {
            return this._service.SchoolbushistoriesIdGetAsync(id);
        }
    }
}
