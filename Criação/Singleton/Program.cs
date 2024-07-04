using System;
class Program
{
    static void Main(string[] args){
        Singleton jogador_1 = Singleton.GetInstancia();
        jogador_1.Mensagem("Jogador 1 está jogando!");

        Singleton jogador_2 = Singleton.GetInstancia();
        jogador_2.Mensagem("Jogador 2 pega a bola!");

        Singleton jogador_3 = Singleton.GetInstancia();
        jogador_3.Mensagem("Jogador 3 rouba e chuta!");

        Console.ReadKey();
    }
}
