using System.Diagnostics;

try
{
    WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllersWithViews().AddSessionStateTempDataProvider();
    builder.Services.AddSession();

    WebApplication app = builder.Build();
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseDefaultFiles();
    app.UseRouting();
    app.UseSession();
    app.MapDefaultControllerRoute();
    app.Use(async (context, next) =>
    {
        try
        {
            if(context.Request.Path.ToString().Contains("favicon.ico") == true)
            {
                context.Response.StatusCode = StatusCodes.Status200OK;
            }
            else
            {
                await next();
            }
        }
        catch(Exception e)
        {
            Debug.WriteLine(e);
            throw e;
        }
    });

    app.Run();
}
catch(Exception e)
{
    Debug.WriteLine(e);
    throw e;
}