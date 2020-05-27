using Twilio.Rest.Api.V2010.Account;

namespace Twilio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            const string authToken = "your_auth_token";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Twilio test",
                from: new Types.PhoneNumber("fromNumber"),
                to: new Types.PhoneNumber("toNumber")
            );
            System.Console.WriteLine(message.Sid);
        }
    }
}
