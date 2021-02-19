using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen_19_02_2021;
using Moq;

namespace Pruebas_unitarias_examen
{
    [TestClass]
    public class UnitTest1
    {
        IMonopatin monopatin;
        ICliente cliente;

        [TestInitialize]
        public void InicializaValores() 
        {
            monopatin = (IMonopatin)new Monopatin(1, "Marca1", 200, 10, 0);
            cliente = (ICliente)new Cliente("Jesús", "Valido Zafra", "12345678Z", 100, 5);

            //Creamos el mock
            //var mockMascota = new Mock<IMascota>();

            //Nos aseguramos de que el comportamiento del mock sea que la mascota se relaje y que al vacunarla lance una excepción
            //para poder controlar este caso
            //mockMascota.Setup(x => x.SeRelaja(It.IsAny<string>())).Returns(true);
        }

        [TestMethod]
        public void Test_CompruebaEstado_DevuelveTrue()
        {
            //Para que el método compruebaEstado devualva true, es necesario que el monopatín no se haya alquilado 20 o más veces
            //Para ello, asignamos al monopatín un valor inferior a 20 mediante el setter de la propiedad vecesAlquilado
            monopatin.VecesAlquilado = 15;

            //A continuación, comprobamos que el método compruebaEstado devuelve true
            Assert.IsTrue(monopatin.compruebaEstado());
        }

        [TestMethod]
        public void Test_CompruebaEstado_DevuelveFalse() 
        {
            //Para que el método compruebaEstado devualva false, es necesario que el monopatín se haya alquilado 20 o más veces
            //Para ello, asignamos al monopatín un valor superior a 20 mediante el setter de la propiedad vecesAlquilado
            monopatin.VecesAlquilado = 25;

            //A continuación, comprobamos que el método compruebaEstado devuelve false
            Assert.IsFalse(monopatin.compruebaEstado());
        }

        [TestMethod]
        public void Test_setValor() 
        {
            //Primero asignamos un valor al monopatín usando el setter
            monopatin.Valor = 12;

            //A continuación, comprobamos que el valor de esa propiedad es 12, tal y como le hemos asignado, con su getter
            Assert.AreEqual(12, monopatin.Valor);
        }

        [TestMethod]
        public void Test_CompruebaAlquiler_MonopatinNecesitaRevision() 
        {
            //Creamos el mock de Monopatin
            var mockPatin = new Mock<IMonopatin>();

            //Le indicamos que el método compruebaEstado va a devolver false
            mockPatin.Setup(x => x.compruebaEstado()).Returns(false);
            //Indicamos el valor de los getters usados en este método
            mockPatin.Setup(x => x.PesoMaximo).Returns(200);
            mockPatin.Setup(x => x.Valor).Returns(10);

            //Asignamos valores necesarios al cliente
            cliente.Saldo = 15;
            cliente.Peso = 100;

            //Comprobamos si devuelve false
            Assert.IsFalse(cliente.CompruebaAlquiler((IMonopatin)mockPatin.Object));
        }

        [TestMethod]
        public void Test_CompruebaAlquiler_MonopatinSoportaPeso() 
        {
            //Creamos el mock
            var mockPatin = new Mock<IMonopatin>();

            //Establecemos el comportamiento requerido de los getters y el método compruebaEstado
            mockPatin.Setup(x => x.PesoMaximo).Returns(200);
            mockPatin.Setup(x => x.Valor).Returns(10);
            mockPatin.Setup(x => x.compruebaEstado()).Returns(true);

            //Asignamos valores al cliente
            cliente.Peso = 100f;
            cliente.Saldo = 15;

            //Comprobamos que el método devuelve true
            Assert.IsTrue(cliente.CompruebaAlquiler((IMonopatin)mockPatin.Object));
        }

        [TestMethod]
        //En esta prueba vamos a comprobar que el método CompruebaAlquiler devuelve false cuando el saldo del cliente es inferior al
        //valor del patín
        public void Test_CompruebaAlquiler_SaldoInsuficiente() 
        {
            //Los valores necesarios del cliente y el monopatín están asignados en el [TestInitialize]
            //El saldo del cliente es 5, mientras que el valor del patín es 10, por lo que debe devolver false
            //El cliente pesa 100 kilos y el patín soporta 200, así que esa parte es correcta
            //El patín no necesita revisión porque se ha alquilado 0 veces, así que esa parte también es correcta

            //Comprobamos que el método devuelve false pasándole dos objetos reales
            Assert.IsFalse(cliente.CompruebaAlquiler(monopatin));
        }
    }
}
