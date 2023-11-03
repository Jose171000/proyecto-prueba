// See https://aka.ms/new-console-template for more information

int totalJugador;
int totalDealer;
int num = 0;
int platziCoins = 0;
string message;
string switchControl = "menu";
string controlOtraCarta;
System.Random random = new System.Random();

//Blackjack, Juntar 21 pidiendo cartas o en caso de
//tener menos de 21 igual tener mayor puntuación que el dealer
while (true)
{
    Console.WriteLine("Bienvenido a P L A T Z I N O");
    Console.WriteLine("¿Cuántos plaztiCoins deseas? \n " +
                      "Ingresa un número entero \n" +
                      "Recuerda que necesitas 1 por ronda de juego");
    platziCoins = Convert.ToInt32(Console.ReadLine()); //necesitamos hacer una conversión a in entero
    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar  al 21");
                switchControl = Console.ReadLine();
                i--;
                break;

            case "21":
                do
                {
                    Console.WriteLine("Toma tu carta, juegador");
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"Tu carta es: {num}");
                    Console.WriteLine("¿Deseas otra carta?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "yes" ||
                         controlOtraCarta == "si" ||
                         controlOtraCarta == "Si");

                totalDealer = random.Next(12, 23);

                Console.WriteLine("El dealer tiene: " + totalDealer);

                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    message = "Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador > 21)
                {
                    message = "Perdiste contra el dealer, tienes más que 21 ";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el Dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "condición no válida";
                    switchControl = "menu";
                }

                Console.WriteLine(message);
                break;

            default:

                Console.WriteLine("Error de dato introducido");
                switchControl = "menu";
                break;
        }

    }
}


