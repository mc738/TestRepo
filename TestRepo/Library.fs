namespace TestRepo



open System

module Test =
    let i = 1


module Foo =

    let j = 1

    let test = "Hello, World!"
    
    /// <summary>An example DU.</summary>
    type DU =
        | Text of string
        | Number of string
    
    /// <summary>A test function</summary>
    /// <param name="a">The first value</param>
    /// <param name="b">The first value</param>
    /// <returns>A string with a and b in seperated by a space.</returns>
    let myFn a b = $"{a} {b}"

    // Hmmm
    let myFn2 (z: int) (b: int) =
        printfn "Hello, World!"
        Async.Sleep 1000 |> Async.RunSynchronously
        z + 1 |> ignore
        b + 1 |> ignore
        z + b |> ignore
        //z + b |> ignore
        ""

    (*
    /// <summary>An example function.</summary>
    let sum a b = a + b



    /// <summary>An example tuple.</summary>
    let sumTuple (a, b) = a + b
    *)

    /// <summary>An example generic function.</summary>
    let generic<'T> (value: 'T) = value


    /// <summary>An example option function.</summary>
    let option<'T> (value: 'T) = Some value

    /// <summary>An example result function.</summary>
    let result<'T> (value: 'T) : Result<'T, string> = Ok value


    /// <summary>An example list.</summary>
    let list<'T> _ = List<'T>.Empty


    /// <summary>An example map.</summary>
    let map _ = Map.empty


    /// <summary>An example record.</summary>
    type Bar = { Value: int }

    /// <summary>An example class</summary>
    type Baz(value: int) =

        member b.Value = value

        member b.Add(bar: Bar) = value + bar.Value
