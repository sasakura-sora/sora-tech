namespace SoraTech.Controllers

open System
open Microsoft.AspNetCore.Mvc

type CVController() =
    inherit Controller()
    member this.Index() = 
        this.View()