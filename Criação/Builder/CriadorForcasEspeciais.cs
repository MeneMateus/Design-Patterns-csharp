public class CriadorForcasEspeciais : CriadorDeSoldado
{
    public CriadorForcasEspeciais()
    {
        _soldado = new SoldadoForcasEspeciais();
    }

    public override void Arma()
    {
        _soldado?.EscolherArma("Fuzil de assaulto");
    }

    public override void Foco()
    {
        _soldado?.DefinirFoco("Infiltração");
    }

    public override void Transporte()
    {
        _soldado?.EscolherTransporte("Carro de transporte de operações especiais");
    }
}