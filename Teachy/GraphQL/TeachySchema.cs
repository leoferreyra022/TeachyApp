using GraphQL.Types;
using Teachy.GraphQL.Query;

namespace Teachy.GraphQL;

public class TeachySchema : Schema
{
	public TeachySchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<TeachyQuery>();
        //Mutation = serviceProvider.GetRequiredService<TeachyMutation>();

        Description = "Example Courses app schema";
    }
}
