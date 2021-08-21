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
            var accountSid = "ACf49965a4223eaaeb569b4fd25dc869bf";
            var authToken = "0f44074f58ae78475bc4744b56de54ac";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+5586981767434"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "*Reunião de estagiários 10:00*";

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);

        }
    }

   
}
