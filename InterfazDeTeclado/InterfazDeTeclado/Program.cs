namespace InterfazDeTeclado;
internal class Program
{
    /*
     Notas => 
     *Para la proxima añadir una funcion que me permita cambiar el color de seleccion 
     *Subir a Github
     */
    
    private static void Main(string[] args)
    {
        //Aqui van las opciones
        string[] opciones = new string[]
{
    "Entrar",
    "Opciones",
    "Salir"

};
        //Este es el loop por el que funciona el menu
        bool loop = true;
        int count = 0;
        ConsoleKeyInfo key;
        

        //Necesito un contador, evaluando el numero de ese contador se decidira que opcion se va a seleccionar

        while (loop)
        {
            Console.Clear();
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == count)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(">" + opciones[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(" " + opciones[i]);
                }
            }

                key = Console.ReadKey(true);
            //Recibe un input 
           
           
            if (key.Key == ConsoleKey.UpArrow) //Realiza una accion dependiendo de la tecla
                {
               
                    count--;
                if (count <0) count = opciones.Length-1;
                    
            }
            else
            if (key.Key == ConsoleKey.DownArrow)
            {
                count++;
                if (count >= opciones.Length) count = 0;


            }
            else           
            if (key.Key == ConsoleKey.Enter)
            {
                if (count == 2)
                {
                    Console.Clear();
                    loop = false;
                }
            }
            

        }
    }

        
}
