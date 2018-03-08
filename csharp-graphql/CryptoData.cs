using System.Linq;
using csharp_graphql.Models;

namespace csharp_graphql
{
    public static class CryptoData
    {
        public static Currency[] Currencies { get; }

        public static CurrencyPair[] CurrencyPairs { get; }

        static CryptoData()
        {
            Currencies = new[] {
                new Currency
                {
                    Name = "Euro",
                    Issuer = "EU",
                    Symbol = "EUR"
                },
                new Currency
                {
                    Name = "Dollar",
                    Issuer = "USA",
                    Symbol = "USD"
                },
                new Currency
                {
                    Name = "Romanian LEU",
                    Issuer = "Romania",
                    Symbol = "RON"
                }
            };

            CurrencyPairs = new[]
            {
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "EUR"),
                    To = Currencies.Single(_ => _.Symbol == "USD"),
                },
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "EUR"),
                    To = Currencies.Single(_ => _.Symbol == "RON"),
                },
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "RON"),
                    To = Currencies.Single(_ => _.Symbol == "USD"),
                },
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "RON"),
                    To = Currencies.Single(_ => _.Symbol == "EUR"),
                },
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "USD"),
                    To = Currencies.Single(_ => _.Symbol == "EUR"),
                },
                new CurrencyPair
                {
                    From = Currencies.Single(_ => _.Symbol == "USD"),
                    To = Currencies.Single(_ => _.Symbol == "RON"),
                }
            };
        }
    }
}