module Tests

open System
open Xunit

let (|DivisibleBy|_|) by n =
    if n % by = 0 then Some DivisibleBy else None

let fizzbuzz n = 
    match n with
    | DivisibleBy 3 & DivisibleBy 5 -> "fizzbuzz"
    | DivisibleBy 3  -> "fizz"
    | DivisibleBy 5  -> "buzz"
    | _ -> string n

[<Fact>]
let ``fizzbuzz returns 1`` () =
    Assert.Equal("1", fizzbuzz 1)
    
[<Fact>]
let ``fizzbuzz returns fizz for numbers divisible by 3`` () =
    Assert.Equal("fizz", fizzbuzz 3)
    Assert.Equal("fizz", fizzbuzz 6)
    Assert.Equal("fizz", fizzbuzz 9)
    
[<Fact>]
let ``fizzbuzz returns buzz for numbers divisible by 5`` () =
    Assert.Equal("buzz", fizzbuzz 5)
    Assert.Equal("buzz", fizzbuzz 10)
    Assert.Equal("buzz", fizzbuzz 20)
    
[<Fact>]
let ``fizzbuzz returns fizzbuzz for numbers divisible by both 3 and 5`` () =
    Assert.Equal("fizzbuzz", fizzbuzz 15)
