public class CriadorDeInfantariaLeve : CriadorDeSoldado
{

    public CriadorDeInfantariaLeve(){
        _soldado = new SoldadoInfantariaLeve();
    }
    public override void Arma()
    {
        _soldado?.EscolherArma("Arma de infantaria leve");
    }

    public override void Foco()
    {
        _soldado?.DefinirFoco("Resposta rápida em solo!");
    }

    public override void Transporte()
    {
        _soldado?.EscolherTransporte("Helicóptero de transporte do exercito");
    }
}