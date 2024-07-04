public class SoldadoForcasEspeciais : Soldado
{
    public override void DefinirFoco(string foco)
    {
        Foco = foco;
        Console.WriteLine($"Soldado Forças Especiais - Foco: {Foco}");
    }


    public override void EscolherArma(string arma)
    {
        Arma = arma;
        Console.WriteLine($"Soldado Forças Especiais - Arma: {Arma}");
    }

    public override void EscolherTransporte(string transporte)
    {
        Transporte = transporte;
        Console.WriteLine($"Soldado Forças Especiais - Transporte: {Transporte}");
    }
}