using GraphQL.Types;

namespace csharp_graphql.GraphQlSchema
{
    public class CryptoSchema : Schema
    {
        public CryptoSchema()
        {
            Query = new CryptoQuery();
        }
    }
}