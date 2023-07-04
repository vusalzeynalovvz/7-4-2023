//using System;

//namespace ConsoleApp1
//{

//    interface IPerson 
//    {
//        void Speak();
    
//    }

//    public class RussianPerson : IPerson
//    {
//        public void Speak()
//        {
//            Console.WriteLine("URusca Salam");
//        }
//    }
//    public class FrenchPerson : IPerson
//    {
//        public void Speak()
//        {
//            Console.WriteLine("Bonjour");
//        }
//    }
//    public class SpanishPerson : IPerson
//    {
//        public void Speak()
//        {
//            Console.WriteLine("Hola");
//        }
//    }




//    class Program
//    {
//        static void Main(string[] args)
//        {
//            RussianPerson russianPerson = new RussianPerson();
//            FrenchPerson frenchPerson = new FrenchPerson();
//            SpanishPerson spanishPerson = new SpanishPerson();
//            russianPerson.Speak();
//            frenchPerson.Speak();
//            spanishPerson.Speak();
            
//        }
//    }
//}

////3).Elave olaraq 3 dene class olmalidi : RussianPerson, FrenchPerson, SpanishPerson.Her uch class IPerson 
////interface-ni implement elemelidi.Her uch klassda Speak() metodun icherisinde sadece hemin dilde "salam" sozunu console-da chixardmalisiniz.