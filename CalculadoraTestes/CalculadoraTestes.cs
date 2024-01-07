using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calculadora.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _calculadora.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calculadora.EhPar(num);

        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void DeveVerificarSe3EhParERetornarFalso()
    {
        //Arrange
        int num = 3;

        //Act
        bool resultado = _calculadora.EhPar(num);

        //Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] { 0, 2, 4, 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act //Assert
        Assert.All(numeros, num => Assert.True(_calculadora.EhPar(num)));
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 7, 9 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarFalso(int[] numeros)
    {
        //Act //Assert
        Assert.All(numeros, num => Assert.False(_calculadora.EhPar(num)));
    }
}