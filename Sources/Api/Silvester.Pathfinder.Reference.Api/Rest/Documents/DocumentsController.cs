using Microsoft.AspNetCore.Mvc;
using Silvester.Pathfinder.Reference.Api.Models;
using Silvester.Pathfinder.Reference.Api.Rest.Documents.Instances;
using Silvester.Pathfinder.Reference.Api.Rest.Documents.Models;
using Silvester.Pathfinder.Reference.Extensions;
using Silvester.Pathfinder.Reference.ModelBinding.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Api.Rest.Documents
{
    public class DocumentsController : ControllerBase
    {
        [HttpGet]
        [Route("documents/{documentType}/versions/{version}")]
        public IActionResult GetDocumentByVersion([FromRoute][FromEnumValue] DocumentType documentType, [FromRoute] int version)
        {
            IDocumentProvider? provider = GetDocumentProvider(documentType, version);
            return provider == null
                ? NotFound(new ErrorResponse($"No '{documentType.GetEnumMemberAttributeValue()}' with version '{version}' could be found.", new { DocumentType = documentType, Version = version }))
                : Ok(provider.Document);
        }

        [HttpGet]
        [Route("documents/{documentType}/versions/latest")]
        public IActionResult GetLatestDocument([FromRoute][FromEnumValue] DocumentType documentType)
        {
            IDocumentProvider? provider = GetLatestDocumentProvider(documentType);
            return provider == null
                ? NotFound(new ErrorResponse($"No latest version could be found for a document of type '{documentType.GetEnumMemberAttributeValue()}'.", new { DocumentType = documentType }))
                : Ok(provider.Document);
        }

        private IDocumentProvider? GetDocumentProvider(DocumentType documentType, int version)
        {
            return GetDocumentProviders()
                .Select(e => (IDocumentProvider)Activator.CreateInstance(e)!)
                .FirstOrDefault(e => e.Type == documentType && e.Version == version);
        }

        private IDocumentProvider? GetLatestDocumentProvider(DocumentType documentType)
        {
            return GetDocumentProviders()
                .Select(e => (IDocumentProvider)Activator.CreateInstance(e)!)
                .Where(e => e.Type == documentType)
                .OrderByDescending(e => e.Version)
                .FirstOrDefault();
        }

        private IEnumerable<Type> GetDocumentProviders()
        {
            return GetType()
                .Assembly
                .GetTypes()
                .Where(e => e.IsClass && e.IsAbstract == false && e.IsAssignableTo(typeof(IDocumentProvider)));
        }
    }
}
