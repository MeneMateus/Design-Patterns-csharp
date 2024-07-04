public class Program {
    static void Main(string[] args){
    FactoryMethod factory = new FactoryMethod();
    

    Console.WriteLine("Liu Kang | SubZero | Scorpion");
    Console.WriteLine();

    Console.WriteLine("Escolha seu personagem");
    string escolha = Console.ReadLine();

    if(!string.IsNullOrEmpty(escolha)){
        IPersonagem personagem = factory.Escolher_personagem(escolha);
        if(personagem != null){
            personagem?.escolhido();
        }
    }
    Console.ReadKey();
}
}

