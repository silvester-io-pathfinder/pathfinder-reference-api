using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DifferentWorlds : Template
    {
        public static readonly Guid ID = Guid.Parse("c5c5de4b-52cf-49bb-9e7e-a8c803c153d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Different Worlds",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8be0219c-c839-4ec4-906c-1b6b42317342"), Type = TextBlockType.Text, Text = $"~ Access: Have earnt Mialari Docur's trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("48dd4728-d7c9-48ed-add7-7f10ab51bc9a"), Type = TextBlockType.Text, Text = $"Your separate experiences in different societies have evolved into entirely separate lives. Create a second identity for yourself with a different name, history, and background. This identity must correspond to one of the ancestries whose ancestry feats you can select. You gain the trained proficiency rank in the Lore skill from the second background you chose (but you don't gain any of the background's other benefits), and you gain a +4 circumstance bonus to Deception checks when making a statement that would be true of your second identity or when disguising yourself as your second identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAncestryAmount(Guid.Parse("a0bcdc94-f9a2-42e4-9a0c-968c2160ba2d"), Comparator.GreaterThanOrEqualTo, amount: 2);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("07a95766-a7cd-49e8-b34c-c7e21ce9fe6c"), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa80e744-9dab-4cf9-b550-ddc391fd26e9"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
