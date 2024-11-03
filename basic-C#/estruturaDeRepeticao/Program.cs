namespace EstruturaDeRepeticao
{
    public class Loop
    {
        public static void Main()
        {

            // For
            // Console.WriteLine("Digite o número que deseja saber a tabuada:\n");
            // int número = Convert.ToInt32(Console.ReadLine());
            // for(int contador = 0; contador <= 10; contador++){
            //     Console.WriteLine($"{número} x {contador} = {número * contador}");
            // }

            // While
            // Console.WriteLine("Digite o número que deseja saber a tabuada:\n");
            // int número = Convert.ToInt32(Console.ReadLine());
            // int contador = 0;
            // while (contador <= 10)
            // {
            //     Console.WriteLine($"{número} x {contador} = {número * contador}");
            //     contador++;
            // }

            // Do While
            Console.WriteLine("Digite o número que deseja saber a tabuada:\n");
            int número = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            do
            {
                Console.WriteLine($"{número} x {contador} = {número * contador}");
                contador++;

            } while (contador <= 10);
        }
    }
}