using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.DAL
{
    public class UnitOfWork// : IDisposable
    {
        private LocalStorage db = new LocalStorage();
        private RepositoryApplication reposApplication;
        private RepositoryEntrant reposEnrant;
        private RepositoryPerson reposPerson;
        private RepositoryDepartment reposDepartment;
        private RepositoryDirection reposDirection;
        private RepositoryCompetitiveGroup reposCompetitiveGroup;
        private RepositoryEntranceTestResult reposEntrantceTestResult;

        public RepositoryApplication Applications
        {
            get
            {
                if (reposApplication == null)
                    reposApplication = new RepositoryApplication(db);
                return reposApplication;
            }
        }
        public RepositoryEntrant Entrants
        {
            get
            {
                if (reposEnrant == null)
                    reposEnrant = new RepositoryEntrant(db);
                return reposEnrant;
            }
        }
        public RepositoryPerson Persons
        {
            get
            {
                if (reposPerson == null)
                    reposPerson = new RepositoryPerson(db);
                return reposPerson;
            }
        }
        public RepositoryDepartment Departments
        {
            get
            {
                if (reposDepartment == null)
                    reposDepartment = new RepositoryDepartment(db);
                return reposDepartment;
            }
        }
        public RepositoryDirection Directions
        {
            get
            {
                if (reposDirection == null)
                    reposDirection = new RepositoryDirection(db);
                return reposDirection;
            }
        }
        public RepositoryCompetitiveGroup  CompetitiveGroups
        {
            get
            {
                if (reposCompetitiveGroup == null)
                    reposCompetitiveGroup = new RepositoryCompetitiveGroup(db);
                return reposCompetitiveGroup;
            }
        }
        public RepositoryEntranceTestResult EntranceTestResults
        {
            get
            {
                if (reposEntrantceTestResult == null)
                    reposEntrantceTestResult = new RepositoryEntranceTestResult(db);
                return reposEntrantceTestResult;
            }
        }
        public void Save()
        {
            //
        }

        public void Dispose()
        {
            //
        }
    }
}
