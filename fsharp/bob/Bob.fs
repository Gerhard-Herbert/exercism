module Bob

open System

let isUppcase (msg : string) = 
    msg.ToCharArray() 
    |> Seq.fold (fun r c -> r && (Char.IsUpper(c) || Char.IsLetter(c) <> true) ) true

let noLetter (msg : string) = 
    msg.ToCharArray() 
    |> Seq.fold (fun r c -> r &&  Char.IsLetter(c) = false) true

let isWhiteSpace (msg : string) = 
    msg.ToCharArray() 
    |> Seq.fold (fun r c -> r &&  Char.IsWhiteSpace(c)) true

let endsWith prefix (msg:string) =
    msg.EndsWith(prefix) 

let isShouting msg =
    isUppcase msg && ((endsWith "?" msg) || (endsWith "!" msg)) 

let hey msg = 
    match msg with
    | _ when isWhiteSpace  msg ->  "Fine. Be that way!"
    | _ when isUppcase msg = false && endsWith "?" msg ->  "Sure."
    | _ when noLetter msg && endsWith "?" msg ->  "Sure."
    | _ when noLetter msg ->  "Whatever."
    | _ when isUppcase msg ->  "Whoa, chill out!"
    | _ ->  "Whatever."

