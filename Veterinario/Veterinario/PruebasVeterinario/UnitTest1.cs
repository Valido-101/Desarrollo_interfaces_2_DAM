using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClínicaVeterinaria;
using Moq;

namespace PruebasVeterinario
{
    [TestClass]
    public class UnitTest1
    {
        ICliente cliente;
        IClinica clinica;
        IMascota mascota;
        IVeterinario veterinario;

        [TestInitialize]
        public void InicializarTests() 
        {
            cliente = (ICliente)new Cliente("Cliente1", "777777Z", "Apellidos1");
            clinica = (IClinica)new Clinica();
            mascota = (IMascota)new Mascota("Pirulo", "26/06/2001");
            veterinario = (IVeterinario)new Veterinario("Ana");
        }

        [TestMethod]
        public void Test_Jugar_CadenaPar()
        {
            //Pasos:
            //Crear un string cuya longitud sea par
            //Dato de prueba: "correr"
            string cadenaPar = "correr";

            //LLamamos al método desde el objeto mascota pasándole la cadena como parámetro
            //y comprobamos que devuelve true
            Assert.IsTrue(mascota.Jugar(cadenaPar)); 
        }

        [TestMethod]
        public void Test_Jugar_CadenaImpar()
        {
            //Pasos:
            //Crear un string cuya longitud sea impar
            //Dato de prueba: "correr"
            string cadenaPar = "comer";

            //LLamamos al método desde el objeto mascota pasándole la cadena como parámetro
            //y comprobamos que devuelve false
            Assert.IsFalse(mascota.Jugar(cadenaPar));
        }

        [TestMethod]
        public void Test_YaVacunado_VacunaExistente() 
        {
            //Pasos:
            //Insertar vacuna manualmente en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            mascota.GetVacunas().Add(vacuna);

            //LLamamos al método y le pasamos esa misma cadena por parámetro
            Assert.IsTrue(mascota.YaVacunado(vacuna));
        }

        [TestMethod]
        public void Test_YaVacunado_VacunaInexistente()
        {
            //Pasos:
            //Crear un string que no esté en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            //LLamamos al método y le pasamos esa misma cadena por parámetro
            Assert.IsTrue(mascota.YaVacunado(vacuna));
        }

        [TestMethod]
        public void Test_Vacunar_VacunaExistente()
        {
            //Pasos:
            //Insertar vacuna manualmente en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            mascota.GetVacunas().Add(vacuna);

            try
            {
                //LLamamos al método y le pasamos esa misma cadena por parámetro
                mascota.Vacunar(vacuna);
                //Si no pasa al bloque del catch es porque el método no funciona como debería, por tanto la prueba debe fallar
                Assert.Fail("No ha saltado la excepción");
            }
            catch (System.Exception)
            {
                //Si entra en el catch la prueba ha sido correcta
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_Vacunar_VacunaInexistente()
        {
            //Pasos:
            //Crear un string que no esté en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            try
            {
                //LLamamos al método y le pasamos esa misma cadena por parámetro
                mascota.Vacunar(vacuna);
                //Si no pasa al bloque del catch es porque el método funciona como debería, por tanto la prueba es exitosa
                Assert.IsTrue(mascota.GetVacunas().Contains(vacuna));
            }
            catch (System.Exception)
            {
                //Si entra en el catch la prueba ha sido incorrecta
                Assert.Fail("Ha saltado la excepción cuando no debería");
            }
        }

        [TestMethod]
        public void Test_PonerVacuna_VacunaExistente() 
        {
            //Pasos:
            //Creamos una vacuna
            string vacuna = "Leishmaniosis";

            //La añadimos manualmente a la lista de vacunas de mascota
            mascota.GetVacunas().Add(vacuna);

            //Comprobamos que al ejecutar el método PonerVacuna devuelve false
            Assert.IsFalse(veterinario.PonerVacuna(mascota, vacuna));
        }

        [TestMethod]
        public void Test_PonerVacuna_VacunaInexistente()
        {
            //Pasos:
            //Creamos una vacuna
            string vacuna = "Leishmaniosis";

            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.YaVacunado("Leishmaniosis")).Returns(false);

            mockMascota.Setup(x => x.Vacunar(vacuna));

            //Comprobamos que al ejecutar el método PonerVacuna devuelve true
            Assert.IsTrue(veterinario.PonerVacuna((IMascota)mockMascota.Object, vacuna));
        }

        [TestMethod]
        public void Test_SeRelaja_CadenaDivisible()
        {
            //Pasos:
            //Para que se puedan realizar pruebas en este método, se ha modificado para que en vez de dividir entre un número aleatorio, se divida entre dos
            //Creamos una cadena par
            string premio = "chuche";

            //LLamamos al método de la clase mascota y comprobamos que devuelve true
            Assert.IsTrue(mascota.SeRelaja(premio));
        }

        [TestMethod]
        public void Test_SeRelaja_CadenaNoDivisible()
        {
            //Pasos:
            //Para que se puedan realizar pruebas en este método, se ha modificado para que en vez de dividir entre un número aleatorio, se divida entre dos
            //Creamos una cadena impar
            string premio = "Pescado";

            //LLamamos al método de la clase mascota y comprobamos que devuelve false
            Assert.IsFalse(mascota.SeRelaja(premio));
        }

        [TestMethod]
        public void Test_AltaCliente() 
        {
            //Pasos:
            //LLamamos al método AltaCliente y le pasamos como parámetro un cliente
            clinica.AltaCliente(cliente);

            //Comprobamos que la lista de clientes contiene el cliente que hemos añadido antes
            //Para esto, he creado un getter de la lista de clientes para poder hacer la comprobación 
            Assert.IsTrue(clinica.Clientes().Contains(cliente));
        }

        [TestMethod]
        public void Test_AltaVeterinario()
        {
            //Pasos:
            //LLamamos al método AltaCliente y le pasamos como parámetro un veterinario
            clinica.AltaVeterinario(veterinario);

            //Comprobamos que la lista de veterinarios contiene el veterinario que hemos añadido antes
            //Para esto, he creado un getter de la lista de veterinarios para poder hacer la comprobación
            Assert.IsTrue(clinica.Veterinarios().Contains(veterinario));
        }
    }
}
