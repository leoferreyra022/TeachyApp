using GraphQL.Types;
using Teachy.DataAccess.Models;

namespace Teachy.GraphQL.Types;

public class UserType : ObjectGraphType<User>
{
	public UserType()
	{
		Field(u => u.Id);
        Field(u => u.FirstName);
        Field(u => u.LastName);
        Field(u => u.NickName);
        Field(u => u.Active);
        Field(u => u.DateCreated);
    }
}
