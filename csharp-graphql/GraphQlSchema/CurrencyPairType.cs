using csharp_graphql.Models;
using GraphQL.Types;

namespace csharp_graphql.GraphQlSchema
{
    public class CurrencyPairType : ObjectGraphType<CurrencyPair>
    {
        public CurrencyPairType()
        {
            Field(x => x.From, type: typeof(CurrencyType)).Description("...");
            Field(x => x.To, type: typeof(CurrencyType)).Description("...");
        }
    }
}