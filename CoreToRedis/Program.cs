using System;
using CoreToRedis.RedisConnection;

namespace CoreToRedis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var redisDataAgent = new RedisDataAgent();

            var testValue = "my first line";
            var testKey = "Key1";
            
            redisDataAgent.SetStringValue(testKey, testValue);
            Console.WriteLine(redisDataAgent.GetStringValue(testKey));

            Console.ReadLine();
        }
    }
}
