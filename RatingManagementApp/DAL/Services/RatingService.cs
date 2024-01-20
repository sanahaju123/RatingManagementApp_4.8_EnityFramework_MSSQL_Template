using RatingManagementApp.DAL.Interrfaces;
using RatingManagementApp.DAL.Services.Repository;
using RatingManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RatingManagementApp.DAL.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _repository;

        public RatingService(IRatingRepository repository)
        {
            _repository = repository;
        }

        public Task<Rating> CreateRating(Rating expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRatingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Rating> GetAllRatings()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Rating> GetRatingById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Rating> UpdateRating(Rating model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}