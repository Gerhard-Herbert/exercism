module DifferenceOfSquares

let square x = x * x

let squareOfSums n =
    [| 1 .. n |]
    |> Array.sumBy( function x -> x)
    |> square

let sumOfSquares n = 
    Array.init (n+1) (function x -> x*x)
    |> Array.sumBy (function x -> x)

let difference n = 
   squareOfSums n - sumOfSquares n