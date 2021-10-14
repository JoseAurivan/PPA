using System.Linq;
using PPA.Models;

namespace PPA.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppContext context)
        {
            context.Database.EnsureCreated();
            if (context.Opiniaos.Any())
            {
                return;
            }

            Opiniao asd = new Opiniao();
            asd.Cpf = "545454545";
            asd.Comentario = "pao";
            asd.Eixo = "asjasidas";
            asd.Email = "sadasdasd";
            asd.Endereco = "asdasdasdasd";
            asd.Nome = "Pao";
            asd.Rg = "1112346";
            asd.Tema = "asldmasdlmasd";
            asd.AreaTematica = "asdlasd";
            asd.NPrograma = "3213";

            context.Opiniaos.Add(asd);
            context.SaveChanges();
        }
    }
}