using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiposDeOperadores
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }        
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} x {y} = {x * y}");
        }        
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }        
        public void Potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }       

        // Seno, Coseno e Tangente 
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            // Console.WriteLine($"O seno de {angulo}° é {seno}");  // forma sem arredondar          
            Console.WriteLine($"O seno de {angulo}° é {Math.Round(seno, 4)}"); // arredondando o valor de seno com 4 casas decimais apenas, usando o método Round 
        }        
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            // Console.WriteLine($"O coseno de {angulo}° é {coseno}");
            Console.WriteLine($"O coseno de {angulo}° é {Math.Round(coseno, 4)}");
        }       
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            // Console.WriteLine($"A tangente de {angulo}° é {tangente}");
            Console.WriteLine($"A tangente de {angulo}° é {Math.Round(tangente, 4)}");
        }        
        public void RaizQuadrada(double num){
            Console.WriteLine($"A raiz quadrada de {num} é {Math.Sqrt(num)}"); // fiz o calculo de raiz quadrada dentro do próprio output
        }
    }
}