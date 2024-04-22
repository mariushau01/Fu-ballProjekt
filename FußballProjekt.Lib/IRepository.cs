using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FußballProjekt.Lib
{
     public interface IRepository
    {
        bool AddTeam(Team team);
        
        bool DeleteTeam(Team team);

        bool Update(Team team, Game game);

        bool Safe(Team team);

        List<Team> GetAll();

    }
}
