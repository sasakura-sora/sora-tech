namespace SoraTech.Controllers

open System
open Microsoft.AspNetCore.Mvc

type AboutController() =
    inherit Controller()
    member this.Index() = 
        this.View()