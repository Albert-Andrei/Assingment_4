using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Assignment_4_Server_Database.DataAccess;
using Assignment_4_Server_Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_4_Server_Database.Data
{
    public class AdultService : IAdultService
    {
        private IList<Adult> adults;
        private AdultContext ctx;

        public AdultService()
        {
            ctx = new AdultContext();
            adults = ctx.Adult.ToList();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> result = new List<Adult>(adults);
            return result;
        }

        public async Task<Adult> AddAdultsAsync(Adult person)
        {
            int max = adults.Max(person => person.Id);
            person.Id = (++max);
            adults.Add(person);
            await ctx.Adult.AddAsync(person);
            await ctx.SaveChangesAsync();
            return person;
        }

        public async Task RemoveAdultsAsync(int personId)
        {
            Adult toRemove = adults.First(t => t.Id == personId);
            adults.Remove(toRemove);
            ctx.Adult.Remove(toRemove);
            await ctx.SaveChangesAsync();
        }

        public async Task UpdateAdultsAsync(Adult person)
        {
            AdultContext dbContext = new AdultContext();
            dbContext.Update(person);
            await dbContext.SaveChangesAsync();
        }
    }
}