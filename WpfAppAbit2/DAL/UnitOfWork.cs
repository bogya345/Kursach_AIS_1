﻿using System;
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
