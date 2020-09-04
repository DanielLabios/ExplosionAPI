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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{letters}")]
        public string GetMumbling(string letters)
        {
            string rr = "";
            var nn = new List<string>();
            var dd = letters.ToCharArray();
            foreach (char ddd in dd)
            {
                nn.Add(ddd.ToString());
            }
            for (var l = 0; 0 < (nn.Count() - l); l++)
            {
                for (var ll = 0; ll <= l; ll++)
                {
                    string p = (ll == 0) ? nn[l].ToUpper() : nn[l].ToLower();
                    rr += p;
                }
                rr = rr + (l == nn.Count() - 1 ? "" : "-");
            }
            return rr;
        }
    }
}