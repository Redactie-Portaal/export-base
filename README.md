# Export.Base

Base library om een export plugin te maken.

## Usage
### Voeg dit project toe als Nuget Package
1. Verkrijg een github Personal access token met de permissions om packages the lezen.
2. voeg het volgende toe aan __AppData\Roaming\NuGet\Nuget.Config__
  ```yaml
<packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
</packageSources>
<packageSourceCredentials>
        <github>
            <add key="Username" value="joepvand" />
            <add key="ClearTextPassword" value="GITHUB PERSONAL ACCESS TOKEN" />
        </github>
    </packageSourceCredentials>
 ```
3. Voeg het nuget package __Export.Base__ toe aan je nieuwe __Class library project__
4. Build je project voor Dotnet 6 naar een dll.
5. Voeg deze dll toe aan __ActorBased-Backend\RedacteurPortaal.Api\bin\Debug\net6.0\ExportPlugins__ of __Microservice Path__ voor microservices project.

## Voorbeeld
```csharp
public class ConsoleExportPlugin : IExportPlugin
    {
        public string Name => "Console Export";

        public string Description => "Sample plugin that writes to the console.";

        public string Icon => "data:image/png;base64,iVBORw0KGgoAAAANS";

        public Guid Id => new Guid();

        public string ApiKeyFormat => "foo|bar";

        public MediaType[] RequestedMediaTypes => new MediaType[] { MediaType.Text };

        public Task Upload(ExportItem item, string apyKey, CancellationToken cancellationToken = default)
        {
            System.Console.WriteLine(item.Name);
            return Task.CompletedTask;
        }
    }
```
