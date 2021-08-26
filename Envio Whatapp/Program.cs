using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Envio_Whatapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TwilioClient.Init(
               Environment.GetEnvironmentVariable("AC7c3bc9d81989148f65486f58111e5276"),
               Environment.GetEnvironmentVariable("d9c98eeff747fc5d103f280aa6c1ffab")
            );

            var message = MessageResource.Create(
               from: new PhoneNumber("whatsapp:+17542276336"),
               to: new PhoneNumber("whatsapp:+5588998731443"),
               body: "Ahoy from Twilio!"
            );

            Console.WriteLine("Message SID: " + message.Sid);

        }
    }

   
}
