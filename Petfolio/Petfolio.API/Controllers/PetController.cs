﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestPetRegisterJson request)
        {
            // business logic

            return Created();
        }
    }
}
