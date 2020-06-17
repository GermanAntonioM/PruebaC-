using System;
using System.Xml;

namespace PruebaDesarrolladorJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio Prueba");
            PruebaArea();
            PruebaStringItem();
            PruebaNumeroPar();
            PruebaSecuenciaFibonacci();

        }

        private static void PruebaSecuenciaFibonacci()
        {
            try
            {
                Console.WriteLine("4.- Indique un numero para determinar el rango en que se realizara la secuencia:  ");
                Console.WriteLine("Numero:");
                int x = Int32.Parse(Console.ReadLine());
                HacerSecuenciaFibonacci(x);
            }
            catch (Exception)
            {

                Console.WriteLine("Digite solo numeros...");
            }
        }

        private static void PruebaNumeroPar()
        {
            try
            {
                Console.WriteLine("3.- Indique Un numero para determinar si este es par o inpar ");
                Console.WriteLine("Numero:");
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine(ComprobarNumeroPar(x)); 

            }
            catch (Exception)
            {

                Console.WriteLine("Digite solo numeros...");
            }
        }

        private static void PruebaStringItem()
        {
            try
            {
                Console.WriteLine("2.- Indique Un numero de items que desea agregar a  la cadena ");
                Console.WriteLine("Numero:");
                int x = Int32.Parse(Console.ReadLine());
                String cadena = "";
                String item;
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("Item (Pueden ser letras o numeros): ");
                    item = Console.ReadLine() + "|";
                    cadena = cadena + item;
                }
                Console.WriteLine(cadena);

                Console.WriteLine(RetornarItemString(cadena));
            }
            catch (Exception)
            {

                Console.WriteLine("Digite un numero...");
                PruebaStringItem();
            }
            

        }

        //Funcion que da inicio a la prueba
        private static void PruebaArea()
        {
            try
            {
                Console.WriteLine("1.- Indique la base y la altura para calcular el area de un triangulo: ");
                Console.WriteLine("Base: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Altura: ");
                int b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El area del triangulo es de: "+ AreaDeUnTriangulo(a, b)); 
            }
            catch (Exception)
            {

                Console.WriteLine("Error: digite solo numeros....");
                PruebaArea();
            }
           
        }


        //Función que calcule el área de un Triángulo. Input(Base, Altura)
        static int AreaDeUnTriangulo(int bas, int altura) {
            try
            {
                int x = bas + altura / 2;

                return x;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        static string RetornarItemString(String cadena) {
            String x;
            String y;
            String z= "No hay A en la cadena";
            Char[] ch = cadena.ToCharArray();
            int i = 1;
            foreach (var Char  in ch)
            {

                i++;
                if (Char.ToString() == ("A"))
                {
                    x = Char.ToString();
                    if (ch[i+1].ToString() == ("|")) {
                        Console.WriteLine("Indice"+ ch[i+1]);
                        y = ch[i - 1].ToString();
                        z = y + x;
                    }
                    else
                    {
                        y = ch[i+1].ToString();
                        z = x+y;
                    }
                    
                }

                


            }

         
            return z;
        }

          

            
        

        static Boolean ComprobarNumeroPar(int numero) {
            if (numero % 2==0) {

                return true;
            }
            else
            {
                return false;
            }
        }

        static void HacerSecuenciaFibonacci(int rango) {
            int x = 0;
            int y = 1;
            int z;

    
            for (int i = 0; i < rango; i++)
            {
                z = x + y;
                x = y;
                y = z;

                Console.WriteLine(y);
            }
        }
    }
}
