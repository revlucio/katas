module Tests

open System
open Xunit
open Xunit

type Game() =
    let mutable score = 0
    member this.Roll(pins) = 
        score <- score + pins
    member this.Score = score

[<Fact>]
let ``rolling 20 gutterballs gives a score of 0`` () =
    let game = new Game()
    
    for i = 1 to 20 do
        game.Roll(0)
    
    Assert.Equal(0, game.Score)

[<Fact>]
let ``rolling all 1s gives a score of 20`` () =
    let game = new Game()
    
    for i = 1 to 20 do
        game.Roll(1)

    Assert.Equal(20, game.Score)
