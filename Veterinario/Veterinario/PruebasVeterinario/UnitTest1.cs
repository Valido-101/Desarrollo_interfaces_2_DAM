using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cl�nicaVeterinaria;
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
            veterinario.SetpremioUsado("Patata");
        }

        [TestMethod]
        public void Test_Jugar_CadenaPar()
        {
            //Pasos:
            //Crear un string cuya longitud sea par
            //Dato de prueba: "correr"
            string cadenaPar = "correr";

            //LLamamos al m�todo desde el objeto mascota pas�ndole la cadena como par�metro
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

            //LLamamos al m�todo desde el objeto mascota pas�ndole la cadena como par�metro
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

            //LLamamos al m�todo y le pasamos esa misma cadena por par�metro
            Assert.IsTrue(mascota.YaVacunado(vacuna));
        }

        [TestMethod]
        public void Test_YaVacunado_VacunaInexistente()
        {
            //Pasos:
            //Crear un string que no est� en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            //LLamamos al m�todo y le pasamos esa misma cadena por par�metro
            Assert.IsFalse(mascota.YaVacunado(vacuna));
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
                //LLamamos al m�todo y le pasamos esa misma cadena por par�metro
                mascota.Vacunar(vacuna);
                //Si no pasa al bloque del catch es porque el m�todo no funciona como deber�a, por tanto la prueba debe fallar
                Assert.Fail("No ha saltado la excepci�n");
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
            //Crear un string que no est� en la lista de vacunas de la mascota
            string vacuna = "Leishmaniosis";

            try
            {
                //LLamamos al m�todo y le pasamos esa misma cadena por par�metro
                mascota.Vacunar(vacuna);
                //Si no pasa al bloque del catch es porque el m�todo funciona como deber�a, por tanto la prueba es exitosa
                Assert.IsTrue(mascota.GetVacunas().Contains(vacuna));
            }
            catch (System.Exception)
            {
                //Si entra en el catch la prueba ha sido incorrecta
                Assert.Fail("Ha saltado la excepci�n cuando no deber�a");
            }
        }

        [TestMethod]
        public void Test_PonerVacuna_VacunaExistente() 
        {
            //Veterinario v = new Veterinario("Ana");
            veterinario.SetpremioUsado("Premio");

            //Creamos un string con la vacuna
            string vacuna = "Leishmaniosis";

            //Creamos el mock
            var mockMascota = new Mock<IMascota>();

            //Nos aseguramos de que el comportamiento del mock sea que la mascota se relaje y que al vacunarla lance una excepci�n
            //para poder controlar este caso
            mockMascota.Setup(x => x.SeRelaja(It.IsAny<string>())).Returns(true);

            mockMascota.Setup(x => x.Vacunar(It.IsAny<string>())).Throws(new System.Exception());

            //Comprobamos que al ejecutar el m�todo PonerVacuna devuelve false
            Assert.IsFalse(veterinario.PonerVacuna((IMascota)mockMascota.Object, vacuna));
        }

        [TestMethod]
        public void Test_PonerVacuna_VacunaInexistente()
        {
            //Pasos:
            //Creamos una vacuna
            string vacuna = "Leishmaniosis";

            //Creamos el mock
            var mockMascota = new Mock<IMascota>();

            //Nos aseguramos de que el m�todo SeRelaja() del mock devuelva true
            mockMascota.Setup(x => x.SeRelaja(It.IsAny<string>())).Returns(true);

            //Comprobamos que al ejecutar el m�todo PonerVacuna devuelve true
            Assert.IsTrue(veterinario.PonerVacuna((IMascota)mockMascota.Object, vacuna));


        }

        [TestMethod]
        public void Test_SeRelaja_CadenaDivisible()
        {
            //Pasos:
            //Para que se puedan realizar pruebas en este m�todo, se ha modificado para que en vez de dividir entre un n�mero aleatorio, se divida entre dos
            //Creamos una cadena par
            string premio = "chuche";

            //LLamamos al m�todo de la clase mascota y comprobamos que devuelve true
            Assert.IsTrue(mascota.SeRelaja(premio));
        }

        [TestMethod]
        public void Test_SeRelaja_CadenaNoDivisible()
        {
            //Pasos:
            //Para que se puedan realizar pruebas en este m�todo, se ha modificado para que en vez de dividir entre un n�mero aleatorio, se divida entre dos
            //Creamos una cadena impar
            string premio = "Pescado";

            //LLamamos al m�todo de la clase mascota y comprobamos que devuelve false
            Assert.IsFalse(mascota.SeRelaja(premio));
        }

        [TestMethod]
        public void Test_AltaCliente() 
        {
            //Pasos:
            //LLamamos al m�todo AltaCliente y le pasamos como par�metro un cliente
            clinica.AltaCliente(cliente);

            //Comprobamos que la lista de clientes contiene el cliente que hemos a�adido antes
            //Para esto, he creado un getter de la lista de clientes para poder hacer la comprobaci�n 
            Assert.IsTrue(clinica.Clientes().Contains(cliente));
        }

        [TestMethod]
        public void Test_AltaVeterinario()
        {
            //Pasos:
            //LLamamos al m�todo AltaCliente y le pasamos como par�metro un veterinario
            clinica.AltaVeterinario(veterinario);

            //Comprobamos que la lista de veterinarios contiene el veterinario que hemos a�adido antes
            //Para esto, he creado un getter de la lista de veterinarios para poder hacer la comprobaci�n
            Assert.IsTrue(clinica.Veterinarios().Contains(veterinario));
        }
    }
}
