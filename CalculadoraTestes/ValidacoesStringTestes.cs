using Calculadora.Services;

namespace CalculadoraTestes;

public class ValidacoesStringTestes
{
    private ValidacoesString _validacoesString;

    public ValidacoesStringTestes()
    {
        _validacoesString = new ValidacoesString();
    }

    [Fact]
    public void DeveContar3CaracteresEmOlaERetornar3()
    {
        //Arrange
        string texto = "Ola";

        //Act
        int resultado = _validacoesString.ContarCaracteres(texto);

        //Assert
        Assert.Equal(3, resultado);
    }
}