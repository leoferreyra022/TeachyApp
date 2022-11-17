using GraphQL.Types;
using Teachy.DataAccess.Data;
using Teachy.GraphQL.Types;

namespace Teachy.GraphQL.Query
{
    public class TeachyQuery : ObjectGraphType
    {
        public TeachyQuery(IUserData userData)
        {
            Name = "Query";

            Field<ListGraphType<UserType>>("User")
                .ResolveAsync(async ctx => await userData.GetUsers());
        }
    }
}
