module HelloWorld

let hello n =
    match n with
    |None -> sprintf "%s" "Hello, World!"
    |Some(n) -> sprintf "Hello, %s!" n

