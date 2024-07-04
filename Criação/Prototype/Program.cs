public class Program
{
    static void Main(string[] args)
    {
        GerenciamentoDeNuvens gerenciador = new GerenciamentoDeNuvens();
        gerenciador["padrão"] = new NuvemConcreta("branco", "azul");
        gerenciador["personalizada"] = new NuvemConcreta("branco", "laranja");

        NuvemConcreta um = gerenciador["padrão"].Clone() as NuvemConcreta;
        NuvemConcreta dois = gerenciador["personalizada"].Clone() as NuvemConcreta;
        NuvemConcreta tres = gerenciador["personalizada"].Clone() as NuvemConcreta;

        Console.ReadKey();
    }
}