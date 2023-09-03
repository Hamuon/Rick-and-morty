using System.Security.Cryptography;

namespace FirstApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Morty morty = new Morty("Fuck", Position.HORSE_MAN, Ability.ADVANCE);
            //morty.Movie();
            morty.SetPosition(Position.SIXTY_NINE);
            morty.ability = Ability.WEAK;
            morty.Name = "AmirSucker";
            //morty.Movie();
            Console.WriteLine(morty);
        }
    }
}
