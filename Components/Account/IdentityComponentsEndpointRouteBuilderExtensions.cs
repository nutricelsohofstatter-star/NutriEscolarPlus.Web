namespace Microsoft.AspNetCore.Routing;
internal static class IdentityComponentsEndpointRouteBuilderExtensions{public static IEndpointConventionBuilder MapAdditionalIdentityEndpoints(this IEndpointRouteBuilder endpoints){return endpoints.MapGet("/Account/Logout",async context=>{context.Response.Redirect("/Account/Login");await Task.CompletedTask;});}}
