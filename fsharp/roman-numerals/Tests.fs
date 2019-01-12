module Tests

open System
open Xunit

let arabicToRoman arabic =
    ([1..arabic]
    |> List.fold(fun acc elem -> acc + "I") "")
        .Replace("IIIII", "V")
        .Replace("IIII", "IV")
        .Replace("VIV", "IX")
        .Replace("VV", "X")
        .Replace("XXXXX", "L")
        .Replace("XXXX", "XL")

[<Fact>]
let ``1 goes to I`` () =
    Assert.Equal("I", arabicToRoman 1)
    
[<Fact>]
let ``2 goes to II`` () =
    Assert.Equal("II", arabicToRoman 2)
    
[<Fact>]
let ``3 goes to III`` () =
    Assert.Equal("III", arabicToRoman 3)
    
[<Fact>]
let ``4 goes to IV`` () =
    Assert.Equal("IV", arabicToRoman 4)
    
[<Fact>]
let ``5 goes to V`` () =
    Assert.Equal("V", arabicToRoman 5)

[<Fact>]
let ``6 goes to VI`` () =
    Assert.Equal("VI", arabicToRoman 6)
    
[<Fact>]
let ``9 goes to IX`` () =
    Assert.Equal("IX", arabicToRoman 9)

[<Fact>]
let ``10 goes to X`` () =
    Assert.Equal("X", arabicToRoman 10)
    
[<Fact>]
let ``40 goes to XL`` () =
    Assert.Equal("XL", arabicToRoman 40)
    
[<Fact>]
let ``50 goes to L`` () =
    Assert.Equal("L", arabicToRoman 50)
