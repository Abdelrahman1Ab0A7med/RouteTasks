namespace WebApplication1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllers();
			var app = builder.Build();

			//         app.UseRouting();
			//         app.UseEndpoints(endpoints => {
			//             endpoints.MapGet("/FirstPage/{id}/{name}", async context =>
			//             {
			//                 int id = Convert.ToInt32(context.Request.RouteValues["id"]);
			//                 string name = context.Request.RouteValues["name"].ToString();
			//                 await context.Response.WriteAsync($"hello ({id}) {name} \nwelcome at FirstPage");
			//             });

			//	endpoints.MapGet("/secondPage/{id:int?}", async context =>
			//	{
			//		await context.Response.WriteAsync("your at secondPage");
			//	});
			//});
			//         app.Run(async ( HttpContext) => { await HttpContext.Response.WriteAsync("you r in home page"); });

			//app.MapGet("/", () => "Hello World!");
			app.MapControllerRoute(
				name: "default",
				pattern: "/{Controller = Home }/{Action = Index}",
				defaults: new {controller = "Home",Action = "Index" }
				);

			app.Run();
		}
	}
}
