using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string GetExplosion(string number)
        {
            string r = "";
            var n = new List<string>();
            var ss = number.ToCharArray();
            foreach (char sss in ss)
            {
                n.Add(sss.ToString());
            }
            foreach (string nn in n)
            {
                for (var l = 1; l <= int.Parse(nn); l++)
                {
                    r = r + nn;
                }
            }
            return r;
        }
    }
}
