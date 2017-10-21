using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiX.Controllers
{
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "Nunc maximus iaculis lorem ut tempor.",
                "Nam malesuada dui at viverra lobortis.",
                "Donec ornare, sapien vitae ornare scelerisque, urna risus porta ante, et vulputate tortor diam sit amet magna.",
                "Nullam purus purus, faucibus ut suscipit eget, bibendum vel ipsum.",
                "Vestibulum risus est, rhoncus sed egestas nec, vulputate ut ligula.",
                "Nam a pellentesque dolor, id condimentum lectus.",
                "In at accumsan ante.",
                "Praesent ut sagittis tortor, non gravida eros.",
                "Curabitur dictum lacinia molestie.",
                "Nullam ac mattis purus, et scelerisque nibh.",
                "Donec lacinia, est vitae feugiat tincidunt, nisl quam tristique tellus, quis condimentum eros erat nec augue."
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
