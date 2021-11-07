using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeatWave : Template
    {
        public static readonly Guid ID = Guid.Parse("835bdec1-e414-4489-a6a5-6f2bbcc13f57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heat Wave",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An effect would deal fire damage to you, even if you resist all the damage.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93154463-f56c-47a6-9b11-accff66ff2e2"), Type = TextBlockType.Text, Text = "You harness the oncoming flames and twist them into a screen of heat and smoke, granting you concealment until the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd9d33cc-cc06-452b-9a5e-a44c1cd11b36"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
