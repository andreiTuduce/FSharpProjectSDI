open System
open System.Diagnostics

let sw = Stopwatch()

// recursive
let rec fiboRec =
  function
  | 0L -> 0L
  | 1L -> 1L
  | n -> fiboRec (n-1L) + fiboRec (n-2L)

sw.Start()
for i in 0L..30L do
  printfn "fiboRec of %d => %d" i (fiboRec i)
sw.Stop()
printfn "Time for normal recursive %f" (float sw.ElapsedMilliseconds)

// tail recursive
let fiboTailRec n =
    let rec loop (n1,n2) i =
      if i < n
      then loop (n1+n2,n1) (i+1I)
      else n1
    loop (0I,1I) 0I

sw.Start()
for i in 0I..30I do
  printfn "fiboTailRec of %A => %A" i (fiboTailRec i)
sw.Stop()
printfn "Time for normal tail recursive %f" (float sw.ElapsedMilliseconds)

let a = 6
let b = 2.3
printfn "%f" (float a + b)

[<EntryPoint>]
let main argv =
    0