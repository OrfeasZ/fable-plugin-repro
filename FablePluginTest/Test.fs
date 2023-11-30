module FablePluginTest.Main

type TestType =
    [<TestPlugin>]
    static member testMethod() = printfn "test"

printfn "Hello Fable world!"