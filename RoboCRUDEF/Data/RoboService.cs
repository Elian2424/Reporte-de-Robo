using Microsoft.EntityFrameworkCore;
using RoboCRUDEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboCRUDEF.Data
{
    public class RoboService : IRoboService
    {

        private readonly MyRContext _context;
        public RoboService(MyRContext context)
        {
            _context = context;
        }


        public async Task<bool> DeleteRobo(int id)
        {
            var robo = await _context.Robos.FindAsync(id);

            _context.Robos.Remove(robo);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Robo>> GetAllRobos()
        {
            return await _context.Robos.ToListAsync();
        }

        public async Task<Robo> GetRoboDetails(int id)
        {
            return await _context.Robos.FindAsync(id);
        }

        public async Task<bool> InsertRobo(Robo robo)
        {
            _context.Robos.Add(robo);

            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> SaveRobo(Robo robo)
        {
            if(robo.RoboId > 0)
            {
                return await UpdateRobo(robo);
            }
            else
            {
                return await InsertRobo(robo);
            }
        }

        public async Task<bool> UpdateRobo(Robo robo)
        {
            _context.Entry(robo).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;


        }
    }
}
