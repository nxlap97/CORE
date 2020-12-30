using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CORE.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CORE.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NFTController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<KatanaZeroModel> GET()
        {
            var model = new List<KatanaZeroModel>();
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "JSONs", "katana-zero.json");

            string jsonStrings = System.IO.File.ReadAllText(file);

            model = JsonConvert.DeserializeObject<List<KatanaZeroModel>>(jsonStrings);

            return model;
        }

        [HttpGet]
        [Route("{token_id}")]
        public KatanaZeroModel GET(string token_id)
        {
            var model = new KatanaZeroModel();

            var valid = ValidateParams(token_id);

            if (!valid)
                return model;

            var lst = new List<KatanaZeroModel>();
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "JSONs", "katana-zero.json");

            string jsonStrings = System.IO.File.ReadAllText(file);

            lst = JsonConvert.DeserializeObject<List<KatanaZeroModel>>(jsonStrings);

            var type = int.Parse(token_id.Substring(0, 3));
            var power = int.Parse(token_id.Substring(3, 3));
            var grade = int.Parse(token_id.Substring(6, 3));

            //var token_id = 



            model = new KatanaZeroModel
            {
                Id = 1,
                Token_image = $"https://api.narwhalswap.org/rune/image/1.png",
                Grade_text = "Grade_text",
                Name = "Name",
                description = "description",
                Effect = "Effect",
                Grade = grade,
                Power = power,
                Types = type,
            };
            return model;
        }

        private bool ValidateParams(string param)
        {
            if (string.IsNullOrWhiteSpace(param) || param.Length < 9)
                return false;
            int init = 0;
            if (!int.TryParse(param, out init))
                return false;

            var type = int.Parse(param.Substring(0, 3));
            var power = int.Parse(param.Substring(3, 3));
            var grade = int.Parse(param.Substring(6, 3));

            if (!(type >= 148 && type <= 150))
                return false;
            if (!(power >= 250 && power <= 300))
                return false;
            if (!(grade >= 100 && grade <= 599))
                return false;

            //148 - (250 => 260) 1.2 init buff
            //148 - (260 => 270) 1.5 init buff
            //148 - (270 => 280) 1.9 init buff
            //148 - (280 => 290) 2.4 init buff
            //148 - (290 => 300) 3.0 init buff

            //149 - (250 => 260) 55% init buff
            //149 - (260 => 270) 60% init buff
            //149 - (270 => 280) 70% init buff
            //149 - (280 => 290) 85% init buff
            //149 - (290 => 300) 105% init buff

            return true;
        }


        private int caculatorTokenId(int type, int power)
        {
            //switch (type)
            //{
            //    case 148:
            //        if (power >= 250 && power <= 260)
            //            return 1;
            //        if (power >= 260 && power <= 270)
            //            return 2;
            //        if (power >= 270 && power <= 280)
            //            return 3;
            //        if (power >= 280 && power <= 290)
            //            return 4;
            //        if (power >= 280 && power <= 290)
            //            return 5;
            //        break;
            //}

            return 1;
        }

    }
}
