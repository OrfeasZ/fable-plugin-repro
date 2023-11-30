namespace FablePluginTest

open Fable

type TestPluginAttribute() =
    inherit MemberDeclarationPluginAttribute()
    override self.FableMinimumVersion = "4.5.0"
    override self.Transform(compiler, file, decl) = decl
    override self.TransformCall(compiler, memb, expr) = expr

// Tell Fable to scan for plugins in this assembly
[<assembly: ScanForPlugins>]
do ()
