module Main

open Expecto

[<Tests>]
let tests =

  testCase "What is going on here?" <| fun _ ->
    Expect.isOk (Program.wtf ()) ""

[<EntryPoint>]
let main argv =
  Tests.runTestsInAssembly defaultConfig argv
