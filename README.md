### Repro

```bash
dotnet tool restore
dotnet fable ./FablePluginTest/FablePluginTest.fsproj -o out --exclude FablePluginTest.Plugin
```