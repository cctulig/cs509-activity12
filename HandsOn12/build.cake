Task("Build")
    .Does(() =>
{
    DotNetCoreBuild("./HandsOn12/HandsOn12.csproj");
});

RunTarget("Build");