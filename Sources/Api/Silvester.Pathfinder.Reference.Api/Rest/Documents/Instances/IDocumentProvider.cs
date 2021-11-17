using Silvester.Pathfinder.Reference.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Reference.Documents.Models;

namespace Silvester.Pathfinder.Reference.Api.Rest.Documents.Instances
{
    public interface IDocumentProvider
    {
        public DocumentType Type { get; }
        public int Version { get; }
        public Document Document { get; }
    }
}