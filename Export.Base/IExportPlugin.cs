namespace Export.Base
{
    public interface IExportPlugin
    {
        public string Name { get; }
        public string Description { get; }

        public string Icon { get; }

        public string ApiKeyFormat { get; }
        public MediaType[] RequestedMediaTypes { get; }

        public Task Upload(ExportItem item, string apyKey, CancellationToken cancellationToken = default);
    }
}