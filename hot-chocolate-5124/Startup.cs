using HotChocolate.AspNetCore;
using HotChocolate.Types.Descriptors;

namespace hot_chocolate_5124
{
    public class Startup
    {
        private readonly IHostEnvironment _environment;

        public Startup(IHostEnvironment env)
        {
            _environment = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .AddIssueTypes()
                .AddQueryType()
                // comment out the below line to remove the HotChocolate.SchemaException
                .AddConvention<INamingConventions, SnakeCaseNamingConvention>()
                .AddMutationConventions();
        }

        public void Configure(IApplicationBuilder app)
        {
            if (!_environment.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }

            app
                .UseRouting()
                .UseEndpoints(endpoint =>
                    endpoint
                        .MapGraphQL()
                        .WithOptions(new GraphQLServerOptions
                        {
                            Tool = { Enable = _environment.IsDevelopment() }
                        })
                );
        }
    }
}