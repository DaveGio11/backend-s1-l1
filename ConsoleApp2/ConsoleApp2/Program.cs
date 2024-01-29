using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente = new Dipendente();
            dipendente.Cognome = "Pinco";
            dipendente.Nome = "Pallino";
            dipendente.RuoloRicoperto = "Amministratore Delegato";
            dipendente.Stipendio = 1560.52;
            dipendente.DataOraEntrata = DateTime.Now;

            Console.WriteLine(dipendente.ScriviDatiDipendente());
            dipendente.FirmaEntrata();
            dipendente.FirmaUscita();
            

            Atleta atleta1 = new Atleta();
            atleta1.Name = "Gianni";
            Console.WriteLine(atleta1.Name);
            atleta1.Categoria(90);
            Console.WriteLine(atleta1.Categoria(90));
            Console.ReadLine();

        }
    }
}
