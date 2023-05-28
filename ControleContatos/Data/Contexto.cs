using Microsoft.EntityFrameworkCore;
using ControleContatos.Data;
using ControleContatos.Models;

namespace ControleContatos.Data
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
              : base(options) { }


        public DbSet <Usuario> Usuarios { get; set; }
    }
}
