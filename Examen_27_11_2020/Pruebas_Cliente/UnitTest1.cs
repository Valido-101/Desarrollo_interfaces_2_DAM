using Examen_27_11_2020;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Pruebas_Cliente
{
    [TestClass]
    public class UnitTest1
    {
        ICliente cliente;
        Paquete paquete;

        [TestInitialize]
        public void CreaCliente() 
        {
            cliente = (ICliente)new Cliente("Nombre1","Apellido1","kjkj","lnln",new System.Collections.ArrayList(),new System.Collections.ArrayList());
            paquete = new Paquete("paquete1", "paquete1", 2, new System.DateTime(2022, 6, 20), 20);
        }

        [TestMethod]
        public void TestCancelarPaquete()
        {
            var mockPaquete = new Mock<IPaquete>();

            mockPaquete.Setup(x => x.Nombre).Returns("Paquete1");

            cliente.PaquetesReservados.Add(paquete);

            cliente.CancelarPaquete(paquete);

            Assert.IsFalse(cliente.PaquetesReservados.Contains(paquete));
        }
    }
}
