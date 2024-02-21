using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalCliente
    {
        public void insertarCliente(CClientes pPersona)
        {
            using (var bd = new BDEXAMENEntities())
            {
                var per = new CLIENTES();
                per.codCliente = pPersona.codigo;
                per.Nombre = pPersona.Nombre;
                per.genero = pPersona.genero;
                bd.CLIENTES.Add(per);
                bd.SaveChanges();
            }
        }
        /*public void eliminarCliente(int codigo)
        {
            using (var bd = new BDEXAMENEntities())
            {
                var per = bd.CLIENTES.First(s => s.codCliente == codigo);
                bd.CLIENTES.Remove(per);
                bd.SaveChanges();
            }
        }*/
    }
}
