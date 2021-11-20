using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Utilities.Text
{
    public enum MarkdownTextFormat
    {
        Plain,
        Markdown
    }

    public class MarkdownText : BaseEntity, IOwnedEntity
    {
        public string Plain { get; set; } = default!;

        public string Markdown  { get; set; } = default!;
        
        public Guid OwnerId { get; set; }

        private static readonly Regex MARKDOWN_LINK = new Regex(@"\[(.*?)\]\(.*?\)", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.CultureInvariant);

        public static MarkdownText FromMarkdown(Guid ownerId, string markdown)
        {
            MatchCollection matches = MARKDOWN_LINK.Matches(markdown);
            string plain = markdown;

            foreach (Match match in matches)
            {
                string text = match.Value.Split("[").Last().Split("]").First();
                plain = plain.Replace(match.Value, text);
            }

            return new MarkdownText
            {
                Id = ownerId,
                OwnerId = ownerId, 
                Plain = plain,
                Markdown = markdown
            };
        }
    }
}
