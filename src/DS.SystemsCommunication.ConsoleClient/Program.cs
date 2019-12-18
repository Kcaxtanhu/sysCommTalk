using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DS.SystemsCommunication.Common.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using Grpc.Net.Client;

namespace DS.SystemsCommunication.ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Registration Console Server");
            Console.WriteLine($"******************* { DateTime.Now } *******************");

            var regists = GetAllRegisteredPersonsFromFile();
            var registsJson = JsonConvert.SerializeObject(regists);

            await StartRegistrationProcess(registsJson);

            var countProcessed = 10;

            // if (countProcessed < regists.Count)
            // {
                var waitingList = regists.Skip(countProcessed);
                var waitingListJson = JsonConvert.SerializeObject(waitingList);

                Console.WriteLine("Sending Message to BUS");
                var factory = new ConnectionFactory() { HostName  = "localhost" };
                using(var connection = factory.CreateConnection())
                using(var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "registrationQueue",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                    string message = waitingListJson;
                    var body = Encoding.UTF8.GetBytes(waitingListJson);

                    channel.BasicPublish(exchange: "",
                                        routingKey: "registrationQueue",
                                        basicProperties: null,
                                        body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                // }
            }


            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }

        private static async Task<int> StartRegistrationProcess(string regists)
        {
            var count = 0;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.RegisterApplicationsAsync(
                              new RegistrationRequest { RegistrationList = regists });
            Console.WriteLine("Greeting: " + reply.NoProcessed);
            count = int.Parse(reply.NoProcessed);

            return count;
        }

        public static IList<Registration> GetAllRegisteredPersonsFromFile()
        {
            var lineConten = File.ReadAllLines(@"C:\Users\User\Documents\PrimeIT\Tech Talks\1. SystemsCommunitcation\src\DS.SystemsCommunication.ConsoleClient\Files\Registration.txt");
            var regists = new List<Registration>();

            foreach (var line in lineConten)
            {
                var lineSplitted = line.Split(';');
                regists.Add(
                    new Registration {
                        Name = lineSplitted[0],
                        RegistrationDate = DateTime.Parse(lineSplitted[1]),
                        Email = lineSplitted[2],
                        MobileNo = lineSplitted[3]
                    }
                );
            }

            return regists;
        }
    }
}
