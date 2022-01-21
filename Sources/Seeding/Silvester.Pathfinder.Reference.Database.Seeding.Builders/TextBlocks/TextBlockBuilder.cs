using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks
{
    public interface ITextBlockBuilder
    {
        TextBlockBuilder Add(Guid id, TextBlockType type, string text);
        TextBlockBuilder Enumeration(Guid id, string text);
        TextBlockBuilder Example(Guid id, string text);
        TextBlockBuilder Footnote(Guid id, string text);
        TextBlockBuilder Heading(Guid id, string text);
        TextBlockBuilder Text(Guid id, string text);
        List<TextBlock> Build();
    }

    public class TextBlockBuilder : ITextBlockBuilder
    {
        private List<TextBlock> TextBlocks { get; }

        public static implicit operator List<TextBlock> (TextBlockBuilder builder) => builder.Build();

        public TextBlockBuilder()
        {
            TextBlocks = new List<TextBlock>();
        }

        public TextBlockBuilder Text(Guid id, string text)
        {
            return Add(id, TextBlockType.Text, text);
        }

        public TextBlockBuilder Heading(Guid id, string text)
        {
            return Add(id, TextBlockType.Heading, text);
        }

        public TextBlockBuilder Enumeration(Guid id, string text)
        {
            return Add(id, TextBlockType.Enumeration, text);
        }

        public TextBlockBuilder Example(Guid id, string text)
        {
            return Add(id, TextBlockType.Example, text);
        }

        public TextBlockBuilder Footnote(Guid id, string text)
        {
            return Add(id, TextBlockType.Footnote, text);
        }

        public TextBlockBuilder Add(Guid id, TextBlockType type, string text)
        {
            TextBlocks.Add(new TextBlock
            {
                Id = id,
                Type = type,
                Text = text
            });

            return this;
        }

        public List<TextBlock> Build()
        {
            return TextBlocks;
        }
    }

    public static class SeedBuilderExtensions
    {
        public static ISeedBuilder AddTextBlocks<TOwner>(this ISeedBuilder self, TOwner owner, Action<ITextBlockBuilder> buildAction, Expression<Func<TOwner, IEnumerable<TextBlock>>> collectionSelector)
            where TOwner : BaseEntity
        {
            ITextBlockBuilder builder = new TextBlockBuilder();
            buildAction.Invoke(builder);

            return self.AddTextBlocks(owner, builder.Build(), collectionSelector);
        }

        public static ISeedBuilder AddTextBlocks<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<TextBlock> textBlocks, Expression<Func<TOwner, IEnumerable<TextBlock>>> collectionSelector)
            where TOwner : BaseEntity
        {
            TextBlock[] asArray = textBlocks.ToArray();
            for (int i = 0; i < asArray.Length; i++)
            {
                TextBlock textBlock = asArray[i];
                textBlock.Order = i;
                textBlock.OwnerId = owner.Id;
            }

            collectionSelector.SetProperty(owner, asArray);
            return self;
        }
    }
}
