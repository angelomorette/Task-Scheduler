using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaskScheduler.Data.Entities;

namespace TaskScheduler.Data.Mapping
{
    /// <summary>
    /// Classe de mapeamento da entidade Usuario
    /// </summary>
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("Usuario");

            Id(u => u.IdUsuario, "IdUsuario").GeneratedBy.Identity();
            Map(u => u.Nome, "Nome").Length(50).Not.Nullable();
            Map(u => u.Email, "Email").Length(20).Not.Nullable().Unique();
            Map(u => u.Senha, "Senha").Length(40).Not.Nullable();
            Map(u => u.DataCadastro, "DataCadastro").Not.Nullable();

        }
    }
}
