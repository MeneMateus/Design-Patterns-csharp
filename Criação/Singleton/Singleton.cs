public sealed class Singleton
{
    private static Singleton? instancia = null;
    private static readonly object lockObject = new object();

    public static Singleton GetInstancia()
    {
        if (instancia == null)
        {
            lock (lockObject)
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo!");
                }
            }
        }
        return instancia;
    }

    public void Mensagem(string msg)
    {
        Console.WriteLine(msg);
    }
}
