public class Adapter : InterfaceAcao
{
    Aviao aviao;

    public Adapter(Aviao aviao)
    {
        this.aviao = aviao;
    }

    public void Andar(string jogador)
    {
        aviao.voar(jogador);
    }

    public void Atirar()
    {
        aviao.soltarMissel();
    }
}