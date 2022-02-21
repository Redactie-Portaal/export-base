
Add a file named `NuGet.Config` to a Class library

    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
        <packageSources>
            <clear />
            <add key="github" value="https://nuget.pkg.github.com/Redactie-Portaal/index.json" />
        </packageSources>
        <packageSourceCredentials>
            <github>
                <add key="Username" value="joepvand" />
                <add key="ClearTextPassword" value="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" />
            </github>
        </packageSourceCredentials>
    </configuration>
