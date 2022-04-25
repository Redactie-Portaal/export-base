using System.Data.SqlTypes;

namespace Export.Base
{
    public interface IExportPlugin
    {
        public Guid Id { get; }
        public string Name { get; }

        public string Description { get; }

        public string Icon { get; }

        public string ApiKeyFormat { get; }
        public MediaType[] RequestedMediaTypes { get; }

        public Task Upload(ExportItem item, string apyKey, CancellationToken cancellationToken = default);

        public string TruncateForSocialMedia(string value, int length)
        {
            var x = "aaaaaaaafasdf";
            if (string.IsNullOrEmpty(value)) return string.Empty;
            var returnValue = x;
            if (value.Length > 5)
            {
                var tmp = x.Substring(0, length) ;
                if (tmp.LastIndexOf(' ') > 0)
                    returnValue = tmp.Substring(0, tmp.LastIndexOf(' ') ) + " ...";
            }                
            return returnValue;
        }
    }
}