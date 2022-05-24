
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
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ELIjah\source\repos\MyLocalDataBases\Oshborn CCSA DB1.mdf1.mdf;Integrated Security=True;Connect Timeout=30")
                .ShowSql())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static ISession CloseSession()
        {
            return null;
        }


        //Implementing CRUD
        public static void AddItem<T>(T item)
        {
            var session = OpenSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(item);
                    transaction.Commit();
                    Console.Write("\n----------------------New row-item successfully created--------------------\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static T ReadItem<T>(T Item)
        {
            var session = OpenSession();
            try
            {
                var item = session.Get<T>(Item);
                Console.Write("\n----------------------Item successfully read------------------\n");
                return item;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static void ReadItem<T>(int id, T item)
        {
            var session = OpenSession();
            try
            {
                var items = session.Get<T>(id);
                Console.Write("\n----------------------Item successfully read------------------\n");
                //return items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return default;
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static void UpdateItem<T>(T item)
        {
            var session = OpenSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(item);
                    transaction.Commit();
                    Console.Write("\n----------------Row-item successfully updated------------------\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Id does not exist");
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        public static void DeleteItem<T>(T item)
        {
            var session = OpenSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(item);
                    transaction.Commit();
                    Console.Write("\n--------------------Item successfully deleted-------------------\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FluentNHibernateHelper.CloseSession();
            }
        }

        // Reset the Database
        public static void ResetSessionFactory()
        {
            string selectedOption1;
            Console.Write("Are you sure you really want to reset the database, as all data would be loss? YES or NO: ");
            selectedOption1 = Convert.ToString(Console.ReadLine());
            if (selectedOption1 == "YES")
            {
                _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ELIjah\source\repos\MyLocalDataBases\Oshborn CCSA DB1.mdf1.mdf;Integrated Security=True;Connect Timeout=30")
                .ShowSql())
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
                Console.Write("\n-------------------Database reset completed----------------------\n");
            }
            else if (selectedOption1 == "NO")
            {
                Console.Write("\n\nOkay goodbye, we will see another time;\n");
            }
            else
            {
                Console.Write("\n\nOops! it seems you entered a wrong option again. Goodbye;\n");
            }
        }
    }
}