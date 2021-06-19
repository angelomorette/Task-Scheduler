using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler.Data.Entities
{
    /// <summary>
    /// Classe de entidade
    /// </summary>
    public class Usuario
    {
        public virtual int IdUsuario { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual DateTime DataCadastro { get; set; }

    }
}
