class Program
{
    static void Main(string[] args)
    {
        var exercito = new Exercito();
        CriadorDeSoldado criadorDeSoldado;
        Soldado? soldado;

        criadorDeSoldado = new CriadorForcasEspeciais();
        exercito.ConstruirSoldado(criadorDeSoldado);
        soldado = criadorDeSoldado.obterSoldado();
        Console.WriteLine("Soldado com caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

        criadorDeSoldado = new CriadorDeInfantariaLeve();
        exercito.ConstruirSoldado(criadorDeSoldado);
        soldado = criadorDeSoldado.obterSoldado();
        Console.WriteLine("Soldado com caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);
    }
}