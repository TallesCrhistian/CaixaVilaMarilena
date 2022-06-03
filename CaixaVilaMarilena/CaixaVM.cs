using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaVilaMarilena
{
    public class CaixaVM
    {
        public float _quantia { get; set; }


        public float Depositar(float valor)
        {
            return _quantia += valor;
        }
    }
}
