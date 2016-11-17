module PrimeFactors
open System

let rec applyDivisor (divisor:Int64) (number:Int64, factors:Int64 list) =
    match (number, factors) with
    | (1L, factors) -> (1L, factors)
    | (n, factors)  when number % divisor <> 0L -> (number, factors)
    | (n, factors)  -> applyDivisor divisor (n / divisor, List.append factors  [divisor])

let primeFactorsFor (number:Int64) =
    Seq.append { 2L .. number/2L} {number..number}
    |> Seq.fold (fun (n, factors) divisor -> applyDivisor divisor (n, factors)) (number, [])
    |> snd
