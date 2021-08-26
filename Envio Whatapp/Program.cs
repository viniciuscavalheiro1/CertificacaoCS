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
            SendSms().Wait();
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }

        static async Task SendSms()
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "AC7c3bc9d81989148f65486f58111e5276";
            const string authToken = "d9c98eeff747fc5d103f280aa6c1ffab";

            TwilioClient.Init(accountSid, authToken);

            var message = await MessageResource.CreateAsync(
                body: "This is the ship that made the Kessel Run in fourteen parsecs?",
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber("+5588998731443")
            );

            Console.WriteLine(message.Sid);
        }
        
    }

   
}
