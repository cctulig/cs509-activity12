Task("Build")
    .Does(() =>
{
    DotNetBuild("./HandsOn12/HandsOn12.csproj");
});

RunTarget("Build");