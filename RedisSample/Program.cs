using StackExchange.Redis;
using System;

namespace RedisSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var redisCon = ConnectionMultiplexer.Connect("localhost");
            var db = redisCon.GetDatabase();
            db.StringSet("foo", "bar");

            string val = db.StringGet("foo");

            Console.WriteLine($"output: {val}");
        }
    }
}
