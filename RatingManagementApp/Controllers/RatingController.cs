using RatingManagement.Models;
using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RatingManagementApp.Controllers
{
    public class RatingController : ApiController
    {
        private readonly IRatingService _service;
        public RatingController(IRatingService service)
        {
            _service = service;
        }
        public RatingController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Rating/CreateRating")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateRating([FromBody] Rating model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Rating/UpdateRating")]
        public async Task<IHttpActionResult> UpdateRating([FromBody] Rating model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Rating/DeleteRating")]
        public async Task<IHttpActionResult> DeleteRating(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Rating/GetRatingById")]
        public async Task<IHttpActionResult> GetRatingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Rating/GetAllRatings")]
        public async Task<IEnumerable<Rating>> GetAllRatings()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
