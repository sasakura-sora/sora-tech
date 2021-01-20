namespace SoraTech

open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open System.IO

module Program =
    let exitCode = 0

    let CreateWebHostBuilder args =
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(fun webBuilder ->
                webBuilder.UseStartup<Startup>() |> ignore
            )

    [<EntryPoint>]
    let main args =
        CreateWebHostBuilder(args).UseContentRoot(Directory.GetCurrentDirectory()).Build().Run()

        exitCode
