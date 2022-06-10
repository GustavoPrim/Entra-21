using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListasObjetos
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            if ((Lado1 + Lado2) > Lado3 || (Lado1 + Lado3) > Lado2 || (Lado2 + Lado3) > Lado1)
                return true;
        }
    }
}
