using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaVilaMarilena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teste = new CaixaVM();
            teste.Depositar(10);

            Console.WriteLine(teste._quantia);
            Console.ReadLine();
        }
    }
}
