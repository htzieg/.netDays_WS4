using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ddfApi.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {
        /// <summary>
        /// gives you THE NUMBER and SENSE OF LIFE
        /// We need to set "Generate XML Docs" in project settings or 
        /// <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
        /// <DocumentationFile>bin\Debug\netcoreapp2.0\ddfApi.xml</DocumentationFile>
        ///</PropertyGroup>
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Generation of a random number succeeded</response>
        /// <response code="304">304</response>
        [HttpGet("next")]
        public int Next()
        {
            return 42;
        }
        /// <summary>
        /// Test method to show exception handling
        /// </summary>
        [HttpGet("throw")]
        public void Throw()
        {
            throw new Exception($"hey ho {DateTime.Now}");
        }
    }
}
