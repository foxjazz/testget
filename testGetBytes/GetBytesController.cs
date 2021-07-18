using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace testGetBytes
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class GetBytesController : ControllerBase
    {
        [HttpGet]
        string GetText()
        {


            return "It is here!";
        }
        /*[HttpGet("/bytes")]
        byte[] Get()
        {


            return read();
        }

        private byte[] read()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "fly.png");
            byte[] bts = System.IO.File.ReadAllBytes(file);
            return bts;
        }*/
      

        
    }
}