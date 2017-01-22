using System;
using System.Collections.Generic;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Repository
    {
        ISessionFactory _sessionFactory;
        ISession _session;

        private static readonly Repository _instance = new Repository();

        private Repository()
        {
            InitializeSession();
        }

        public static Repository Instance
        {
            get
            {
                return _instance;
            }
        }

        void InitializeSession()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("Data Source=KRISTINA/AUBRETT;Initial Catalog=HR;Integrated Security=True;Pooling=False"))
                    .Mappings(m => m
                    .FluentMappings.AddFromAssemblyOf<Repository>())
                    .BuildSessionFactory();
                _session = _sessionFactory.OpenSession();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public IList<Employee> GetAllEmployees()
        {
            try
            {
                return _session.QueryOver<Employee>().List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetEmployee(Guid id)
        {
            try
            {
                return _session.Get<Employee>(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee AddEmployee(Employee employee)
        {
            Employee entity = null;
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    employee.EmployeeId = Guid.NewGuid();
                    //employee.First = DateTime.Now;
                    entity = _session.Save(employee) as Employee;
                    transaction.Commit();
                }
                catch (StaleObjectStateException ex)
                {
                    try
                    {
                        entity = _session.Merge(employee);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                return entity;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    _session.Update(employee);
                    transaction.Commit();
                }
                catch (StaleObjectStateException ex)
                {
                    try
                    {
                        _session.Merge(employee);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

            }
        }

        public void DeleteEmployee(Guid id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                var employee = _session.Get<Employee>(id);
                if (employee != null)
                {
                    try
                    {
                        _session.Delete(employee);
                        transaction.Commit();
                    }
                    catch (StaleObjectStateException ex)
                    {
                        try
                        {
                            _session.Merge(employee);
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
