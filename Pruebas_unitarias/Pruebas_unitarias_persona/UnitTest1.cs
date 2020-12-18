using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pruebas_unitarias;
using System;

namespace Pruebas_unitarias_persona
{
    [TestClass]
    public class UnitTest1
    {
        IPersona persona;

        IPersona persona_copia;
        
        [TestInitialize]
        public void creaPersona() 
        {
            //Creamos lo necesario
            persona = (IPersona)new Persona("Juan", "Ben�tez", 39);

            persona_copia = (IPersona)new Persona();
        }

        [TestMethod]
        public void Test_setNombre() 
        {
            //Usamos el set
            persona.setNombre("Mar�a");

            //Comprobamos
            Assert.AreEqual("Mar�a", persona.getNombre());
        }

        [TestMethod]
        public void Test_getNombre()
        {
            //Ejecutamos el m�todo del objeto real
            string nombre = persona.getNombre();

            //Comprobamos
            Assert.AreEqual("Juan", nombre);
        }

        [TestMethod]
        public void Test_setApellido()
        {
            //Usamos el set
            persona.setApellido("L�pez");

            //Comprobamos
            Assert.AreEqual("L�pez", persona.getApellido());
        }

        [TestMethod]
        public void Test_getApellido() 
        {
            //Ejecutamos el m�todo del objeto real
            string apellidos = persona.getApellido();

            //Comprobamos
            Assert.AreEqual("Ben�tez", apellidos);
        }

        [TestMethod]
        public void Test_setEdad()
        {
            //Usamos el set
            persona.setEdad(19);

            //Comprobamos
            Assert.AreEqual(19, persona.getEdad());
        }

        [TestMethod]
        public void Test_getEdad()
        {
            //Ejecutamos el m�todo del objeto real
            int edad = persona.getEdad();

            //Comprobamos
            Assert.AreEqual(39, edad);
        }

        [TestMethod]
        public void Test_copiaPersona() 
        {
            //Copiamos los datos de persona a persona_copia
            persona_copia.copiaPersona((Persona)persona);

            //Comprobamos
            Assert.AreEqual(persona.getNombre(), persona_copia.getNombre());
            Assert.AreEqual(persona.getApellido(), persona_copia.getApellido());
            Assert.AreEqual(persona.getEdad(),persona_copia.getEdad());
            Assert.AreEqual(persona.getKmRecorridos(), persona_copia.getKmRecorridos());
            Assert.AreEqual(persona.getPareja(),persona_copia.getPareja());
        }

        [TestMethod]
        public void Test_NombreCompleto() 
        {
            //String que deber�a devolver seg�n la persona creada
            string nombreCompleto = "Nombre Completo: Juan Ben�tez";

            //Comprobamos
            Assert.AreEqual(nombreCompleto, persona.nombreCompleto());
        }

        [TestMethod]
        public void Test_Nacer_NoVivo()
        {
            System.Exception ex = null;

            persona.morir();

            //Como la persona no est� viva, comprobamos que no lanza una excepci�n
            try
            {
                persona.nacer();
            }
            catch (System.Exception e)
            {
                //Assert.IsTrue(e.Message == "Ha vuelto a nacer");
                ex = e;
            }

            //Comprobamos
            if (ex != null)
            {               
                Assert.Fail();
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_Nacer_YaVivo() 
        {
           System.Exception ex = null;

            //Como la persona ya est� viva, comprobamos que lanza una excepci�n
            try
            {
                persona.nacer();
            }
            catch (System.Exception e)
            {
                //Assert.IsTrue(e.Message == "Ha vuelto a nacer");
                ex = e;
            }

            //Comprobamos
            if (ex!=null)
            {
                Assert.IsTrue(ex.Message == "Ha vuelto a nacer");
            }
            else
            {
                Assert.Fail("No se ha lanzado la excepci�n");
            }
        }

        [TestMethod]
        public void Test_morir_NoMuerto() 
        {
            //Como la persona no est� muerta, comprobamos que no lanza una excepci�n
            try
            {
                persona.morir();

                Assert.IsTrue(true);
            }
            catch(Exception e)
            {
                //Si recogemos una excepci�n, el m�todo no ha funcionado como deber�a
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Test_morir_YaMuerto()
        {
            //Como la persona est� muerta, comprobamos que lanza una excepci�n
            try
            {
                persona.morir();

                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                //Si recogemos una excepci�n, el m�todo no ha funcionado como deber�a
                Assert.Fail();
            }
        }
    }
}
