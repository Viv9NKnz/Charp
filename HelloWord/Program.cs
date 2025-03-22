namespace Helloword
{

    class Program
    {

        static void Main()
        {
       DateOnly DateConverted =new DateOnly();  
       String nameInput;
       String Birthdayinput;
       Console.WriteLine("!Hola Bienvenido a el calculador de años¡");
       Console.WriteLine("!Escribe tu nombre:¡");
       nameInput= Console.ReadLine();
       Console.WriteLine($"Un gusto conocerte {nameInput}");
       Console.WriteLine("Escribe tu fecha de  en formato dd/mm/yy:");
       Birthdayinput= Console.ReadLine();
       bool isDateValid= DateOnly.TryParse(Birthdayinput,out DateConverted);
       if(isDateValid==false) Console.WriteLine($"la fecha de nacimiento es invalida usted nos envio este dato erroneo{Birthdayinput} ");

       Console.WriteLine();






        }

    }

    public class person{
 
        public String Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }

}
