module Tests

open System
open Xunit

let rec arabicToRoman arabic = 
    match arabic with
    | 0 -> ""
    | arabic when arabic < 4 -> "I" + arabicToRoman(arabic - 1)
    | 4 -> "IV"
    | arabic when arabic < 9 -> "V" + arabicToRoman(arabic - 5)
    | 9 -> "IX"
    | arabic when arabic < 40 -> "X" + arabicToRoman(arabic - 10)
    | arabic when arabic < 50 -> "XL" + arabicToRoman(arabic - 40)
    | arabic when arabic < 100 -> "L" + arabicToRoman(arabic - 50)
    | 100 -> "C" + arabicToRoman(arabic - 100)

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
let ``33 goes to XXXIII`` () =
    Assert.Equal("XXXIII", arabicToRoman 33)
    
[<Fact>]
let ``40 goes to XL`` () =
    Assert.Equal("XL", arabicToRoman 40)

[<Fact>]
let ``41 goes to XLI`` () =
    Assert.Equal("XLI", arabicToRoman 41)
    
[<Fact>]
let ``50 goes to L`` () =
    Assert.Equal("L", arabicToRoman 50)
    
[<Fact>]
let ``55 goes to LV`` () =
    Assert.Equal("LV", arabicToRoman 55)
    
[<Fact>]
let ``100 goes to C`` () =
    Assert.Equal("C", arabicToRoman 100)
