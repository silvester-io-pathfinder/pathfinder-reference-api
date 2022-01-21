using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirectionalBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("36ba2e7f-301e-43ab-8492-b1f7db0692a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Directional Bombs",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c46d7be9-f538-4d3b-9743-4e6f302b37f0"), Type = TextBlockType.Text, Text = $"You can lob bombs with great force and a precise trajectory to angle the splash in a cone spraying in a single direction. When throwing an alchemical bomb with the {ToMarkdownLink<Models.Entities.Trait>("splash", Traits.Instances.Splash.ID)} trait, instead of splashing all squares adjacent to the target, you can treat the target's space as the first affected square of a 15-foot cone directed away from you, potentially allowing you to avoid allies and splash deeper into enemy lines. If the target takes up more than a single square, the target's square closest to you is the first affected square of the cone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3a27e30-64d3-46bb-b47a-fc82a24623a2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
