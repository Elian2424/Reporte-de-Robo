using RoboCRUDEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboCRUDEF.Data
{
    public interface IRoboService
    {
        Task<IEnumerable<Robo>> GetAllRobos();
        Task<Robo> GetRoboDetails(int id);

        Task<bool> InsertRobo(Robo robo);
        Task<bool> UpdateRobo(Robo robo);
        Task<bool> DeleteRobo(int id);

        Task<bool> SaveRobo(Robo robo);
    }
}
