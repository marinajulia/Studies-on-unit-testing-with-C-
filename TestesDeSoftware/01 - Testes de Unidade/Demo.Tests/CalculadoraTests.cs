 namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            //primeiro parametro é a expectativa, o segundo é a resposta do método
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(4,2,6)]
        [InlineData(7,3,10)]
        [InlineData(6,6,12)]
        [InlineData(9,9,18)]
        public void Calculdora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }

        //Assert's:

        //Assert.Equal("string", "String", true); o terceiro parâmetro  é o ignoreCase
        //Assert.StartsWith("Mar", "Marina", true); se começa com o valor proposto
        //Assert.StartsWith("ina", "Marina", true); se termina com o valor proposto
        //Assert.Contains("ina", "Marina"); se contém o valor dentro de outra string
        //Assert.Matches("[Regex]", valor_cpf); para validar itens como cpf, email..
    }
}
