using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculadora
{
    [TestClass]
    public class CalculadoraTest
    {

        [DataRow(4, 4, 8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 2)]
        [TestMethod]
        public void sumaTest(int a, int b, int esperado)
        {
            //Arrange
            /*int a = 4;
            int b = 4;
            int esperado = 8;*/

            //Act
            int actual = Calculadora.Calculadora.suma(a, b);

            //Assert
            Assert.AreEqual(esperado,actual);


        }
    }
}
