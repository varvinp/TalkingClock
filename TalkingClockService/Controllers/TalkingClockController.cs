using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  HumanFriendlyClock;
using Newtonsoft.Json.Linq;

namespace TalkingClockService.Controllers
{
    [Route("api/TalkingClockController")]

    [ApiController]
    public class TalkingClockController : ControllerBase
    {

        // GET api/TalkingClockController/5:00

        [HttpGet("{time}")]
        public ActionResult<JObject> Get(string time)
        {
            try
            {
                var humanFriendlyTime = string.IsNullOrEmpty(time) || time == "\"\"" ? Time.GetHumanFriendlyTime(DateTime.Now) : Time.GetHumanFriendlyTime(Convert.ToDateTime(time));

                var jsonData = @"{'Human Friendly Text':" + "'" + humanFriendlyTime.Replace("'", "\\'") + "'" + "}";

                return JObject.Parse(jsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new HttpRequestException("An error occured in rest service when getting response.");
            }
            
        }
    }
}
