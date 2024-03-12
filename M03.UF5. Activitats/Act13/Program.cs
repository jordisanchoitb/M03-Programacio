/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 
 * 
*/
namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            SpaceShip spaceship = new SpaceShip();
            spaceship.Rocket.Ignicion('T', 1234);
            spaceship.Rocket.UpdateAngle();
        }
    }
}
