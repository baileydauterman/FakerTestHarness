﻿namespace FakerTestHarness.Russian
{
    internal static class Lorem
    {
        public static void Test()
        {
            Console.WriteLine(Faker.NET.RU.Lorem.Lorem.GetText(5));
            Console.WriteLine(Faker.NET.RU.Lorem.Lorem.GetText(50));
        }
    }
}
