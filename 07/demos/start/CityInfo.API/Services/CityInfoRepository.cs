﻿using CityInfo.API.DbContexts;
using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {

        private readonly CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); 
        }
        public Task<IEnumerable<City>> GetCities()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<City?> GetCitiesAsync(int cityId, bool includePointsOfInterest)
        {
            if(includePointsOfInterest)
            {
                return await _context.Cities.Include(c => c.PointsOfInterest)
                    .Where(c => c.Id == cityId).FirstOrDefaultAsync();
            }
            return await _context.Cities.Include(c => c.PointsOfInterest)
                    .Where(c => c.Id == cityId).FirstOrDefaultAsync();
            
        {
        }

        public Task<City?> GetCityAsyng(int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<PointOfInterest?> GetPointOfInterestForCityAsync(
            int cityId, int pointOfInterestId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
