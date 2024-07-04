public class Program
{
    static void Main(string[] args)
    {
        Personagem personagem = new Personagem();
        Aviao aviao = new Aviao();

        InterfaceAcao adapter = new Adapter(aviao);

        Console.WriteLine("--------CAMINHANDO--------");
        personagem.Andar("Mateus");
        personagem.Atirar();

        Console.WriteLine("--------VOANDO--------");
        adapter.Andar("Rafael");
        adapter.Atirar();

        Console.WriteLine();

    }
}