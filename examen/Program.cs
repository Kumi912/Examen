using System;
class Program
{
    public static void Main()
    {
        int totalTortas = 0; // Variable para guardar el total de tortas
        int totalTacos = 0; // Variable para guardar el total de tacos
        
        bool continuar = true; // Creamos una variable continuar y la inicializamos en verdadero
        while (continuar) // Iniciamos otra vez si continuar es verdadero
        {    
            Console.WriteLine("Cantidad de tortas"); // Solicitamos al usuario la cantidad de tortas
            int tortas = int.Parse(Console.ReadLine()); // Guardamos la cantidad de tortas en la variable tortas
            totalTortas = totalTortas += tortas; // Sumamos la cantidad de tortas a la variable totalTortas y guardamos el resultado en totalTortas
            
            Console.WriteLine("Cantidad de tacos"); // Solicitamos al usuario la cantidad de tacos
            int tacos = int.Parse(Console.ReadLine()); // Guardamos la cantidad de tacos en la variable tacos
            totalTacos = totalTacos += tacos; // Sumamos la cantidad de tacos a la variable totalTacos y guardamos el resultado en totalTacos
            
            CochinitaFeliz cochinitaFeliz = new CochinitaFeliz(tortas, tacos, totalTacos, totalTortas); //Creamos una clase

            Console.WriteLine("¿Otro cliente? (si/no)"); // Preguntamos al usuario si hay otro cliente
            string respuesta = Console.ReadLine().ToLower(); // Guardamos la respuesta del usuario en minúsculas
            continuar = respuesta == "si"; // Si la respuesta es si se reinicia el bucle
            
            if (!continuar) // Si es diferente a si
            {
                Console.WriteLine("Tortas vendidas: " + cochinitaFeliz.CuantasTortas()); // Llamamos al método CuantasTortas y mostramos el total de tortas vendidas
                Console.WriteLine("Tacos vendidos: " + cochinitaFeliz.CuantosTacos()); // Llamamos al método CuantosTacos y mostramos el total de tacos vendidos
                Console.WriteLine("Total de ventas: " + cochinitaFeliz.RegistraVenta()); // Llamamos al método RegistraVenta y mostramos el total de ventas
                Console.WriteLine("¿Vendí el triple de tacos que de tortas? " + cochinitaFeliz.VendiElTripleDeTacos()); // Llamamos al método VendiElTripleDeTacos y mostramos si se vendió el triple de tacos que de tortas
            }
        }
    }


    public class CochinitaFeliz // Creamos la clase CochinitaFeliz
    {
        public int Tortas { get; set; } // Iniciamos la variable del objeto
        public int Tacos { get; set; } // Iniciamos la varianle del objeto
        public int TotalTacos { get; set; } // Iniciamos la variable del objeto
        public int TotalTortas { get; set; } // Iniciamos la variable del objeto


        public CochinitaFeliz(int tortas, int tacos, int totalTacos, int totalTortas) // Constructor de la clase CochinitaFeliz
        {
            Tortas = tortas; // Igualamos la variable Tortas con el valor de tortas
            Tacos = tacos; // Igualamos la variable Tacos con el valor de tacos
            TotalTacos = totalTacos; // Igualamos la variable TotalTacos con el valor de totalTacos
            TotalTortas = totalTortas; // Igualamos la variable TotalTortas con el valor de totalTortas
        }

        public int RegistraVenta() // Método para registrar la venta
        {
            int total =  TotalTacos + TotalTortas; // Sumamos el total de tacos y tortas y guardamos el resultado en la variable total
            return total; // Retornamos el total
        }
    
        public int CuantasTortas() // Método para saber cuantas tortas se vendieron
        {
            return TotalTortas; // Retornamos el total de tortas
        }

        public int CuantosTacos() // Método para saber cuantos tacos se vendieron
        {
            return TotalTacos; // Retornamos el total de tacos
        }

        public string VendiElTripleDeTacos() // Método para saber si se vendió el triple de tacos que de tortas
        {
            if (Tacos > Tortas * 3) // Si la cantidad de tacos es mayor a la cantidad de tortas multiplicada por 3
            {
                return "Si"; // Retornamos Si
            }
            else // Si no
            {
                return "No"; // Retornamos No
            }
        }
    }
}