class Program
{
    static void Main(string[] args){
        IFabricaBases? fabrica;
        Console.WriteLine("Escolha uma raça: 1-Protoss | 2-Zergs | 3-Terranos");
        {
            fabrica = Console.ReadLine() switch
                {
                    "1" => fabrica = new FabricaBaseProtoss(),
                    "2" => fabrica = new FabricaBaseZerg(),
                    "3" => fabrica = new FabricaBaseTerran(),
                    _ => null
                };
    }

        Console.ReadLine();
    }
}