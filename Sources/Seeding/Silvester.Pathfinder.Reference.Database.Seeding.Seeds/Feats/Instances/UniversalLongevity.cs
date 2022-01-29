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
    public class UniversalLongevity : Template
    {
        public static readonly Guid ID = Guid.Parse("5c7382a3-9c2d-423e-9612-1658be67c9da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Universal Longevity",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6336928-f112-47a4-bcab-949ce60c80d9"), Type = TextBlockType.Text, Text = $"You've perfected your ability to keep up with all the skills you've learned over your long life, so you're almost never truly untrained at a skill. You reflect on your life experiences, changing the skills you selected with {ToMarkdownLink<Models.Entities.Feat>("Ancestral Longevity", Feats.Instances.AncestralLongevity.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Expert Longevity", Feats.Instances.ExpertLongevity.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("81102d25-1f59-4879-a03f-a47bf669b698"), Feats.Instances.ExpertLongevity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e05ef4d-26c0-45a3-935c-edc98320a5c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
