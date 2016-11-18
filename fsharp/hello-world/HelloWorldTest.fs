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
    Assert.AreEqual(hello None, "Hello, World!")

[<Test>]
let ``Sample name`` () =
    Assert.AreEqual(hello (Some "Alice"), "Hello, Alice!")

[<Test>]
let ``Other sample name`` () =
    Assert.AreEqual(hello (Some "Bob"), "Hello, Bob!")