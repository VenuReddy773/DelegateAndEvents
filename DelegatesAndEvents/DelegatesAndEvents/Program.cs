using System;

namespace DelegatesAndEvents
{
    class Program
    {
        public static event DelEventHandler Add;
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates And Events program!!\n");
            operations obj = new operations(DelegateDemo.Addition); // : Single Delegate.
            Console.WriteLine("Single Delegate!!...Addition is {0}\n",obj(25,25));
            Console.WriteLine("MultiCast Delegates...\n");
            MultiCastDelegate.ImplementDelegate();          // : MultiCast Delegate.
            Console.WriteLine("Events....\n");
            Add += new DelEventHandler(EventsDemo.India);   // : Events.
            Add += new DelEventHandler(EventsDemo.Florida);
            Add += new DelEventHandler(EventsDemo.Usa);
            Add.Invoke();
            
        }
    }
}
