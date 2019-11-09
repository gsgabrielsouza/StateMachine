using System;
using Stateless;
using Stateless.Graph;
using StateMachine.Phone;

namespace StateMachine
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var phoneCall = new PhoneCall("MyFriend");
            phoneCall.Print();
            phoneCall.Dialed("Prameela");
            phoneCall.Print();
            phoneCall.Connected();
            phoneCall.Print();
            phoneCall.SetVolume(2);
            phoneCall.Print();
            phoneCall.Hold();
            phoneCall.Print();
            phoneCall.Mute();
            phoneCall.Print();
            phoneCall.Unmute();
            phoneCall.Print();
            phoneCall.Resume();
            phoneCall.Print();
            phoneCall.SetVolume(11);
            phoneCall.Print();


            Console.WriteLine(phoneCall.ToDotGraph());

            Console.WriteLine("Press any key...");
            Console.ReadKey(true);
        }
    }
}
