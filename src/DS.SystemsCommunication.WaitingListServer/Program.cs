using System;
using System.Text;
using DS.SystemsCommunication.Common.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DS.SystemsCommunication.WaitingListServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Waiting List Console Server");
            Console.WriteLine($"******************* { DateTime.Now } *******************");

            IEnumerable<Registration> waitingList = new List<Registration>();

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "registrationQueue",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);

                    waitingList = (List<Registration>)JsonConvert.DeserializeObject(message);
                };
                channel.BasicConsume(queue: "registrationQueue",
                                    autoAck: true,
                                    consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
