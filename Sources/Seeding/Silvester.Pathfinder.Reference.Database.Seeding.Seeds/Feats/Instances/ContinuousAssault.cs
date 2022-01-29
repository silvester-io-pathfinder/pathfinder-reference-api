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
    public class ContinuousAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("d27d7d38-82a0-411c-8af1-fab09c6c7435");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Continuous Assault",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08662f6e-ff55-435e-947f-790116fc0f26"), Type = TextBlockType.Text, Text = $"You can use {ToMarkdownLink<Models.Entities.Feat>("Elemental Assault", Feats.Instances.ElementalAssault.ID)} once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("31a2294d-1f83-4e6a-9159-c142bb2701b2"), Feats.Instances.ElementalAssault.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a1a8a17c-f2c0-47f8-8081-b6b1cdc96ca0"), Traits.Instances.Suli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12add20c-c607-40d1-bb4b-3fbb2b752dcd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
