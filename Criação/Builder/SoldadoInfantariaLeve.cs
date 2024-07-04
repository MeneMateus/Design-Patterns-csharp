public class SoldadoInfantariaLeve : Soldado
{

    public override void DefinirFoco(string foco)
    {
        Foco = foco;
        Console.WriteLine($"Soldado Infantaria Leve - Foco: {Foco}");
    }


    public override void EscolherArma(string arma)
    {
        Arma = arma;
        Console.WriteLine($"Soldado Infantaria Leve - Arma: {Arma}");
    }

    public override void EscolherTransporte(string transporte)
    {
        Transporte = transporte;
        Console.WriteLine($"Soldado Infantaria Leve - Transporte: {Transporte}");
    }

}