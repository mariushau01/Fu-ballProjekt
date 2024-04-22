using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FußballProjekt.Lib
{
    public class SQLiteRepository : IRepository
    {
        private string _path = string.Empty;
        public SQLiteRepository(string path)
        {
            this._path = path;
        }

        bool IRepository.AddTeam(Team team)
        {
            try
            {
                using (var context = new TeamContext(_path))
                {
                    context.Add(team);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        bool IRepository.DeleteTeam(Team team)
        {
            try
            {
                using (var context = new TeamContext(_path))
                {
                    context.Database.ExecuteSqlRaw("DELETE FROM Team WHERE ID={0}", team.Id);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        List<Team> IRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        bool IRepository.Safe(Team team)
        {
            return true;
        }


        public bool Update(Team team, Game game)
        {
            throw new NotImplementedException();
        }
    }
}
