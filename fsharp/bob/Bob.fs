module Bob

open System

let checkAll (msg : string) condition = 
    msg.ToCharArray()
    |> Seq.fold (fun r c -> r && (condition c)) true

let isAllUppercase msg = checkAll msg (fun c -> Char.IsUpper c  || not (Char.IsLetter c))
let noLetter msg = checkAll msg (fun c -> Char.IsLetter c |> not)
let atLeastOneLetter msg = noLetter msg |> not
let isYelling msg = isAllUppercase msg && atLeastOneLetter msg 
let endsWith prefix (msg:string) = msg.EndsWith(prefix) 
let isQuestion msg =  endsWith "?" msg
let isEmpty msg = checkAll msg (fun c -> Char.IsWhiteSpace c)

let hey msg = 
    match msg with
    | _ when isEmpty  msg ->  "Fine. Be that way!"
    | _ when isYelling msg ->  "Whoa, chill out!"
    | _ when isQuestion msg ->  "Sure."
    | _ ->  "Whatever."

