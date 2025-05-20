using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS9.KeyToAwesomenessLab
{
    class Program
    {
        static void Main(string[] args)
        {
            void Serve(string customerName, CoffeeKind kind, CoffeeSize size, int strength)
            {
                Console.WriteLine($"Serving a {size} {kind} of strength {strength} to {customerName}");
            }


            IList<ServingInfo> servingInfos = GetServings();

            Dictionary<CoffeeKey, int> servingSummaries = new Dictionary<CoffeeKey, int>();

            foreach (var servingInfo in servingInfos)
            {
                var key = new CoffeeKey(servingInfo.Kind, servingInfo.Size, servingInfo.Strength);

                if (!servingSummaries.ContainsKey(key))
                {
                    servingSummaries[key] = 1;
                    continue;
                }

                servingSummaries[key]++;
            }

            var finalSummary = servingSummaries
                .OrderByDescending(summary => summary.Value)
                .ThenBy(summary => summary.Key.Kind)
                .ThenByDescending(summary => summary.Key.Size)
                .ThenByDescending(summary => summary.Key.Strength);

            foreach (var summary in finalSummary)
            {
                var key = summary.Key;
                var count = summary.Value;

                Console.WriteLine($"Serving {count} {key.Size} {key.Kind} of strength {key.Strength}");
            }
        }

        private static IList<ServingInfo> GetServings()
        {
            RandomHelper helper = new();
            List<ServingInfo> servingInfos = new();

            for (int i = 0; i < 100; i++)
            {
                servingInfos.Add(new ServingInfo
                {
                    CustomerName = helper.GetRandomName(),
                    Kind = helper.GetRandomCoffeeKind(),
                    Size = helper.GetRandomCoffeeSize(),
                    Strength = helper.GetRandomCoffeeStrength()
                });
            }
            return servingInfos;
        }

        private class ServingInfo
        {
            public string CustomerName { get; init; }
            public CoffeeKind Kind { get; init; }
            public CoffeeSize Size { get; init; }
            public int Strength { get; init; }
        }

        private record CoffeeKey(CoffeeKind Kind, CoffeeSize Size, int Strength);
    }
}
