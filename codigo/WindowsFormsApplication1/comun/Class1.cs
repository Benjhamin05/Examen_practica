using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CClientes
    {
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public string genero { get; set; }

        public override string ToString()
        {
            return string.Format("Cliente (codigo={0}, nombre={1}, genero={2})",
                                  codigo, Nombre, genero);
        }

    }
}
