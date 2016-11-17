module PrimeFactors
open System

let rec getFactor (divisor:Int64) (n:Int64, factors:Int64 list) =
    match (n, factors) with
    | (1L, factors) -> (1L, factors)
    | (n, factors)  when n % divisor <> 0L -> (n, factors)
    | (n, factors)  -> getFactor divisor (n / divisor, List.append factors  [divisor])

let primeFactorsFor (number:Int64) =
    seq {for i = 2L to number/2L do yield i; yield number}
    |> Seq.fold (fun (n, factors) d -> getFactor d (n, factors)) (number, [])
    |> snd

let x = primeFactorsFor (2L)

let number = 10L
let s = seq {for i = 2L to number/2L do yield i}
s