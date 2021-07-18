using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace testGetBytes
{
    [Route("[controller]")]
    [ApiController]
    public class GetBytesController : ControllerBase
    {

        [HttpGet]
        byte[] Get()
        {


            return read();
        }

        private byte[] read()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "fly.png");
            byte[] bts = System.IO.File.ReadAllBytes(file);
            return bts;
        }
    }
}