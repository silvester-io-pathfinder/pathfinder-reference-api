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
    public class AnchoringRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("41e73f8f-d1c8-44ef-a9a9-2bbeb58c19e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anchoring Roots",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57507b14-3293-424f-99bf-f86750287743"), Type = TextBlockType.Text, Text = $"Small roots sprout from your feet, steadying you as you move. You gain the {ToMarkdownLink<Models.Entities.Feat>("Steady Balance", Feats.Instances.SteadyBalance.ID)} skill feat, even if you aren't trained in Acrobatics, and you can use the {ToMarkdownLink<Models.Entities.Feat>("Anchor", Feats.Instances.Anchor.ID)} action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0fa0982c-d1e8-4865-9625-51c558df61d7"), Traits.Instances.Leshy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca6fb903-1f0d-4d4d-bb2c-a1679220b55e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
