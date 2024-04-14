open System

let mutable input: string = ""
let mutable random: Random = new Random()
let mutable d6: int = 1
let mutable kind: string = ""
let mutable answer: string = ""
let mutable while_break: bool = false

printfn "Welcome to CRandom (n-c-fs)!"
printfn " - CRandom / .NET8.0 Console F# - "

while not while_break do
  printfn "Input command or Close by 'Crtl + C'"
  input <- stdin.ReadLine()
  // printfn "%s" input

  // character
  if input = "c" then
    d6 <- random.Next(1, 7)
    kind <- "character"
    answer <-
      match d6 with
        | 1 -> "energitic"
        | 2 -> "quiet"
        | 3 -> "shy"
        | 4 -> "high-spirited"
        | 5 -> "foolish"
        | 6 -> "aggressive"
        | _ -> "ERROR: Exception"
    printfn "%s" answer

  elif input = "exit" then
    while_break <- true
