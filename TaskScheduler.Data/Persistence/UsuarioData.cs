using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using TaskScheduler.Data.Entities;
using TaskScheduler.Data.Util;

namespace TaskScheduler.Data.Persistence
{
    /// <summary>
    /// Classe de persistência para a entidade Usuario
    /// </summary>
    public class UsuarioData
    {
        public void Insert(Usuario u)
        {
            using (ISession s = HibernateUtil.GetSessionFactory().OpenSession())
            {
                ITransaction t = s.BeginTransaction();
                s.Save(u);
                t.Commit();
            }
        }

        public void Delete(Usuario u)
        {
            using (ISession s = HibernateUtil.GetSessionFactory().OpenSession())
            {
                ITransaction t = s.BeginTransaction();
                s.Delete(u);
                t.Commit();
            }
        }

        public void Update(Usuario u)
        {
            using (ISession s = HibernateUtil.GetSessionFactory().OpenSession())
            {
                ITransaction t = s.BeginTransaction();
                s.Update(u);
                t.Commit();
            }
        }

        public Usuario Find(int IdUsuario)
        {
            using (ISession s = HibernateUtil.GetSessionFactory().OpenSession())
            {
                return (Usuario)s.Get(typeof(Usuario), IdUsuario);
            }
        }

        public ICollection<Usuario> FindAll()
        {
            using(ISession s = HibernateUtil.GetSessionFactory().OpenSession())
            {
                //LINQ - Language Integrated Query
                var query = from u in s.Query<Usuario>()
                            select u;
                //retornar os dados...
                return query.ToList();
            }

        }
    }
}
