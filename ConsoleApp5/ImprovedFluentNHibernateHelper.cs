using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;


namespace ConsoleApp5
{
    public class ImprovedFluentNHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory _sessionFactory;
        static ImprovedFluentNHibernateHelper()
        {
            _sessionFactory = FluentConfigure();
        }
        public static ISession GetCurrentSession()
        {
            return _sessionFactory.OpenSession();
        }
        public static void CloseSession()
        {
            _sessionFactory.Close();
        }
        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }

        public static ISessionFactory FluentConfigure()
        {
            return Fluently.Configure()
                //which database
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ELIjah\source\repos\MyLocalDataBases\Oshborn CCSA DB1.mdf1.mdf;Integrated Security=True;Connect Timeout=30")
                          .ShowSql())
                .Cache(c => c.UseQueryCache().UseSecondLevelCache().ProviderClass<NHibernate.Cache.HashtableCacheProvider>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory();
        }


        //Implementing CRUD for School
        public static void AddSchool(School school)
        {

            var session = ImprovedFluentNHibernateHelper.GetCurrentSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(school);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ImprovedFluentNHibernateHelper.CloseSession();
            }
        }
        
        public static School ReadSchool(int id)
        {
            var session = ImprovedFluentNHibernateHelper.GetCurrentSession();
            try
            {
                var school = session.Get<School>(id);
                return school;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                ImprovedFluentNHibernateHelper.CloseSession();
            }
        }
        public static void UpdateSchool(School school)
        {
            var session = ImprovedFluentNHibernateHelper.GetCurrentSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(school);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ImprovedFluentNHibernateHelper.CloseSession();
            }
        }

        public static void DeleteSchool(School school)
        {
            var session = ImprovedFluentNHibernateHelper.GetCurrentSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(school);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ImprovedFluentNHibernateHelper.CloseSession();
            }
        }
        public static void DeleteSpecificSchool(School school)
        {
            var session = GetCurrentSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    //var schools = from school in session.Query<School>() select school;
                    //var schools = session.Query<School>();
                    session.Delete(session.Query<School>(school.Name));
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ImprovedFluentNHibernateHelper.CloseSession();
            }
        }

        // Reset the Database
        public static void ResetSessionFactory()
        {
                 Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ELIjah\source\repos\MyLocalDataBases\Oshborn CCSA DB1.mdf1.mdf;Integrated Security=True;Connect Timeout=30")
                .ShowSql())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
        }
        //public void DisplayAllCustomers()
        //{
        //    ISession session = ImprovedFluentNHibernateHelper.GetCurrentSession();
        //    try
        //    {
        //        using (ITransaction tx = session.BeginTransaction())
        //        {
        //            var customers = from customer in session.Query<Customer>() select customer;

        //            foreach (var f in customers)
        //            {
        //                Console.WriteLine("{0} {1} {2}", f.Id, f.FirstName, f.LastName);
        //            }
        //            tx.Commit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        ImprovedFluentNHibernateHelper.CloseSession();
        //    }
        //}
    }
}
