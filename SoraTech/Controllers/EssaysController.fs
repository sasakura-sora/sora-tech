namespace SoraTech.Controllers

open System
open Microsoft.AspNetCore.Mvc

type EssaysController() =
    inherit Controller()
    member this.Index() = 
        this.View()