#if INTERACTIVE
#r @"..\..\packages\NUnit\lib\net45\nunit.framework.dll"
#r @"..\..\packages\Unquote\lib\net45\Unquote.dll"
#load "HelloWorld.fs"
#endif
module HelloWorldTest

open NUnit.Framework
open Swensen.Unquote

open HelloWorld

[<Test>]
let ``No name`` () =
    hello None =! "Hello, World!"

[<Test>]
let ``Sample name`` () =
    hello (Some "Alice") =! "Hello, Alice!"

[<Test>]
let ``Other sample name`` () =
    hello (Some "Bob") =! "Hello, Bob!"