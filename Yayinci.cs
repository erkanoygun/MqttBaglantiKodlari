using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Text;

namespace MqttKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttClient mqttClient = new MqttClient("broker.hivemq.com");
            string clientId = Guid.NewGuid().ToString();

            mqttClient.Connect(clientId);
            Console.WriteLine("Abone Olundu: test/deneme");

            Console.WriteLine("Mesajı girin: ");
            string message = Console.ReadLine();
            string Topic = "test/deneme";
            mqttClient.Publish(Topic, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

        }
    }
        
 }

