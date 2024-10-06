namespace testenewtalents;
using NewTalents;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "06/10/2024";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = construirClasse();

        //Act
        int resultadoCalculadora = calc.somar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = construirClasse();

        //Act
        int resultadoCalculadora = calc.multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDivir(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = construirClasse();

        //Act
        int resultadoCalculadora = calc.dividir(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = construirClasse();

        //Act
        int resultadoCalculadora = calc.subtrair(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Given
        Calculadora calc = construirClasse();

        // When

        // Then
        Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        // Given
        Calculadora calc = construirClasse();

        // When
        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}