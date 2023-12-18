/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 14/12/2023
 * 22. Implementa un programa que simuli el moviment d'un objecte en un entorn 2D, representant així un escenari de videojoc. 
 * L'objecte té una posició inicial en l'origen (0, 0) i es mou en funció d'una velocitat i direcció controlades per funcions trigonomètriques. 
 * La velocitat inicial de l'objecte és d'1.0 unitats per segon, i 
 * la direcció inicial és de 45 graus respecte a l'eix positiu x. Durant la simulació, 
 * la direcció de l'objecte canviarà en intervals de 10 graus per a simular esdeveniments en el joc. 
 * Mostra la posició actual de l'objecte en cada iteració de la simulació.
 * La simulació ha de tenir una durada total de 5 segons. Implementa el seu test unitari.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgEndSimulacion = "Simulacio finalitzada.";
            const string MsgPosicionActual = "Posició actual de l'objecte: {0:N4}, {1:N4}";

            double persona_x=0, persona_y=0 ,velocitat=1.0, direccio=45.0 , velocitat_x, velocitat_y, temps=0.0, graus=0.0;
            
            Console.WriteLine(MsgPosicionActual, persona_x ,persona_y);
            while (temps < 5.0)
            {
                velocitat_x = velocitat * Math.Cos(direccio);
                velocitat_y = velocitat * Math.Sin(direccio);

                persona_x += velocitat_x;
                persona_y += velocitat_y;

                Console.WriteLine(MsgPosicionActual, persona_x, persona_y);

                graus += 10.0;
                direccio = graus * Math.PI / 180.0;

                temps += 1.0;
            }
            Console.WriteLine(MsgEndSimulacion);
        }
    }
}