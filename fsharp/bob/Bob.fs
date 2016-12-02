module Bob
open System

let atLeastOneLetter msg = msg |> Seq.exists Char.IsLetter

let (|Silent|Yelling|Question|Other|) msg =
    if String.IsNullOrWhiteSpace(msg) then Silent
    else if atLeastOneLetter msg && msg.ToUpper() = msg then Yelling
    else if msg.EndsWith("?") then Question
    else Other
     
let hey msg = 
    match msg with
    | Silent  msg ->  "Fine. Be that way!"
    | Yelling msg ->  "Whoa, chill out!"
    | Question msg ->  "Sure."
    | _ ->  "Whatever."

