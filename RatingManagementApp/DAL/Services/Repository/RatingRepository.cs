using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RatingManagementApp.DAL.Services.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DatabaseContext _dbContext;
        public RatingRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Rating> CreateRating(Rating expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRatingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Rating> GetAllRatings()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Rating> GetRatingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Rating> UpdateRating(Rating model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}