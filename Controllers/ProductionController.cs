using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTest1.Controllers
{
    [ApiController]
    [Route("api/production")]
    public class ProductionController : ControllerBase
    {
        [HttpGet("yield")]
        public IActionResult GetYield([FromQuery] int tenantID)
        {
           

            if (tenantID == 4000001 || tenantID == 4000002 || tenantID == 4000003)
            {
                var data = new[]
                {
                    new { process = "正极合浆", yield = Random.Shared.Next(1000,1500) },
                    new { process = "正极涂布", yield = Random.Shared.Next(1000,1500)},
                    new { process = "正极辊分", yield = Random.Shared.Next(1000,1500) },
                    new { process = "正极激光切", yield = Random.Shared.Next(1000,1500) },
                    new { process = "负极合浆", yield = Random.Shared.Next(1000,1500)},
                    new { process = "负极涂布", yield = Random.Shared.Next(1000,1500) },
                    new { process = "负极辊分", yield = Random.Shared.Next(1000,1500)},
                    new { process = "负极激光切", yield = Random.Shared.Next(1000,1500) },
                    new { process = "叠片",yield = Random.Shared.Next(1000,1500)},
                    new { process = "组装",yield = Random.Shared.Next(1000,1500) },
                    new { process = "一次注液", yield = Random.Shared.Next(1000,1500) },
                    new { process = "化成", yield = Random.Shared.Next(1000,1500)},
                    new { process = "二次注液", yield = Random.Shared.Next(1000,1500)},
                    new { process = "分容", yield = Random.Shared.Next(1000,1500)},
                    new { process = "补电", yield = Random.Shared.Next(1000,1500)},
                    new { process = "包胶", yield = Random.Shared.Next(1000,1500)},
                    new { process = "组盘", yield = Random.Shared.Next(1000,1500)}

                 };

                return Ok(new
                {
                    code = 200,
                    data
                });
            }
            else 
            {
                var data = new[]
                {
                    new { process = "正极合浆",yield =0 },
                    new { process = "正极涂布", yield =0  },
                    new { process = "正极辊分", yield =0  },
                    new { process = "正极激光切", yield =0  },
                    new { process = "负极合浆", yield =0 },
                    new { process = "负极涂布", yield =0  },
                    new { process = "负极辊分", yield =0 },
                    new { process = "负极激光切", yield =0  },
                    new { process = "叠片", yield =0  },
                    new { process = "组装", yield =0  },
                    new { process = "一次注液", yield =0  },
                    new { process = "化成", yield =0 },
                    new { process = "二次注液", yield =0  },
                    new { process = "分容", yield =0  },
                    new { process = "补电", yield =0  },
                    new { process = "包胶", yield =0  },
                    new { process = "组盘", yield =0  }

                    //new { process = "正极合浆", plan = 0,actaul=0 },
                    //new { process = "正极涂布", plan = 0,actaul=0 },
                    //new { process = "正极辊分", plan = 0,actaul=0 },
                    //new { process = "正极激光切", plan = 0,actaul=0 },
                    //new { process = "负极合浆", plan = 0,actaul=0},
                    //new { process = "负极涂布", plan = 0,actaul=0 },
                    //new { process = "负极辊分", plan = 0,actaul=0 },
                    //new { process = "负极激光切", plan = 0,actaul=0 },
                    //new { process = "叠片", plan = 0,actaul=0 },
                    //new { process = "组装", plan = 0,actaul=0 },
                    //new { process = "一次注液", plan = 0,actaul=0 },
                    //new { process = "化成", plan = 0,actaul=0 },
                    //new { process = "二次注液", plan = 0,actaul=0 },
                    //new { process = "分容", plan = 0,actaul=0 },
                    //new { process = "补电", plan = 0,actaul=0 },
                    //new { process = "包胶", plan = 0,actaul=0 },
                    //new { process = "组盘", plan = 0,actaul=0 }

                 };

                return Ok(new
                {
                    code = 200,
                    data
                });
            }
                

           
        }

        [HttpGet("lines")]
        public IActionResult GetLines()
        {
            var lines = new[]
            {
            new { tenantID = 4000001, name = "产线 A" },
            new { tenantID = 4000002, name = "产线 B" },
            new { tenantID = 4000003, name = "产线 C" }
        };

            return Ok(new { code = 200, data = lines });
        }
    }
}
