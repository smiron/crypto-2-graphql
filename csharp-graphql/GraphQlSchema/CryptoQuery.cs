using System;
using System.Linq;
using GraphQL.Types;

namespace csharp_graphql.GraphQlSchema
{
    public class CryptoQuery : ObjectGraphType<object>
    {
        public CryptoQuery()
        {
            Name = "query";
            var symbolArgumentName = "symbol";

            Field<ListGraphType<CurrencyType>>(
                name: "currency", 
                arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = symbolArgumentName }),
                resolve: context =>
                {
                    string symbol = context.GetArgument<string>(symbolArgumentName);

                    if (!string.IsNullOrEmpty(symbol))
                    {
                        return CryptoData.Currencies.Where(_ => string.Compare(_.Symbol, symbol, StringComparison.OrdinalIgnoreCase) == 0);
                    }

                    return CryptoData.Currencies;
                });
        }
    }
}