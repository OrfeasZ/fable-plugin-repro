module FablePluginTest

open FablePluginTest.Plugin

type TestType =
    [<TestPlugin>]
    static member testMethod() = printfn "test"

printfn "Hello Fable world!"