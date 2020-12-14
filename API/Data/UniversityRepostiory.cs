using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class UniversityRepostiory
    {
        private readonly UniversityContext db;

        public UniversityRepostiory(UniversityContext db)
        {
            this.db = db;
        }
    }
}
