namespace SoraTech

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.HttpOverrides

type Startup() =

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    member this.ConfigureServices(services: IServiceCollection) =
        services.AddControllersWithViews().AddRazorRuntimeCompilation() |> ignore

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member this.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if env.EnvironmentName = "Development" then 
            app.UseDeveloperExceptionPage() |> ignore

        let options = new ForwardedHeadersOptions()
        options.ForwardedHeaders <- (ForwardedHeaders.XForwardedFor ||| ForwardedHeaders.XForwardedProto)
        app.UseForwardedHeaders(options) |> ignore

        app.UseStaticFiles() |> ignore

        app.UseRouting() |> ignore

        app.UseEndpoints(fun endpoints -> 
            endpoints.MapControllerRoute("default", "{controller=CV}/{action=Index}") |> ignore
        )|> ignore
