module Tests

open System
open Xunit

let arabicToRoman arabic =
    "I"

[<Fact>]
let ``1 goes to I`` () =
    Assert.Equal("I", arabicToRoman 1)
