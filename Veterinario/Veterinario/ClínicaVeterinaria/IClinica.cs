using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public interface IClinica
    {
        List<ICliente> Clientes();

        List<IVeterinario> Veterinarios();

        void AltaCliente(ICliente c);
        void AltaVeterinario(IVeterinario v);
    }
}
