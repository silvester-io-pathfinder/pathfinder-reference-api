using Silvester.Pathfinder.Official.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Official.Documents.Models;

namespace Silvester.Pathfinder.Official.Api.Rest.Documents.Instances
{
    public interface IDocumentProvider
    {
        public DocumentType Type { get; }
        public int Version { get; }
        public Document Document { get; }
    }
}