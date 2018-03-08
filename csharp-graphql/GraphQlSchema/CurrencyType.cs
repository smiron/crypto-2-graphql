using System;
using System.Linq;
using csharp_graphql.Models;
using GraphQL.Types;

namespace csharp_graphql.GraphQlSchema
{
    public class CurrencyType : ObjectGraphType<Currency>
    {
        public CurrencyType()
        {
            Field(x => x.Name).Description("...");
            Field(x => x.Symbol).Description("...");
            Field(x => x.Issuer).Description("...");

            var currencyPairArgumentName = "pair";

            Field<ListGraphType<CurrencyPairType>>("pairs",
                arguments: new QueryArguments(new QueryArgument<StringGraphType>{ Name = currencyPairArgumentName }),
                resolve: context =>
                {
                    string pair = context.GetArgument<string>(currencyPairArgumentName);

                    var ret = CryptoData.CurrencyPairs
                        .Where(_ => string.Compare(_.From.Symbol, context.Source.Symbol, StringComparison.OrdinalIgnoreCase) == 0);

                    if (!string.IsNullOrEmpty(pair))
                    {
                        ret = ret.Where(_ => string.Compare(_.To.Symbol, pair, StringComparison.OrdinalIgnoreCase) == 0);
                    }

                    return ret.ToArray();
                });
        }
    }
}