public class FactoryMethod
{
    public IPersonagem? Escolher_personagem(String personagem)
    {
        return personagem switch
        {
            "Liu Kang" => new LiuKang(),
            "Scorpion" => new Scorpion(),
            "Sub Zero" => new SubZero(),
            _ => null,
        };
    }
}