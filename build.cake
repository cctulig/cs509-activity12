var target = Argument("target", "Clean");

Task("Clean")
    .Does(() => {
    DotNetClean("./HandsOn12/HandsOn12.sln");
});

RunTarget (target);