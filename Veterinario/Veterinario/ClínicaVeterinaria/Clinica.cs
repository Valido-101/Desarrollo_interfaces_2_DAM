using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public class Clinica : IClinica
    {
        private List<ICliente> clientes = new List<ICliente> ();
        private List<IVeterinario> veterinarios = new List<IVeterinario>();

        public Clinica() { }

        public void AltaCliente(ICliente c)
        {
            clientes.Add((ICliente)new Cliente("","",""));
        }
        public void AltaVeterinario(IVeterinario v)
        {
            veterinarios.Add(v);
        }

        public List<ICliente> Clientes()
        {
            return clientes;
        }

        public List<IVeterinario> Veterinarios()
        {
            return veterinarios;
        }
    }
}
