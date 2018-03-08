using csharp_graphql.GraphQlSchema;

namespace csharp_graphql.Models
{
    public class CurrencyPair
    {
        public Currency From { get; set; }

        public Currency To { get; set; }
    }
}