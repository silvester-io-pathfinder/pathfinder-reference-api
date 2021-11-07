using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirectionalBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("85169688-5d09-47bc-8287-0eb0ff442e18");

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
            yield return new TextBlock { Id = Guid.Parse("703de12e-9410-4e0b-938b-2ba8672f56d8"), Type = TextBlockType.Text, Text = "You can lob bombs with great force and a precise trajectory to angle the splash in a cone spraying in a single direction. When throwing an alchemical bomb with the (trait: splash) trait, instead of splashing all squares adjacent to the target, you can treat the target’s space as the first affected square of a 15-foot cone directed away from you, potentially allowing you to avoid allies and splash deeper into enemy lines. If the target takes up more than a single square, the target’s square closest to you is the first affected square of the cone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8616d21-5d81-482c-be76-561374ff1104"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
