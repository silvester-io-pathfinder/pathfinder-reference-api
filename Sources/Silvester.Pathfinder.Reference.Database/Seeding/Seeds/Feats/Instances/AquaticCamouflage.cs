using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AquaticCamouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("15b28359-f6f5-4e34-a266-e03fb0a93c1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aquatic Camouflage",
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
            yield return new TextBlock { Id = Guid.Parse("a9f732c9-07f1-471b-96cf-387cc6eabe60"), Type = TextBlockType.Text, Text = "You blend into the waves. While fully submerged in water, as long as an observer is at least 20 feet away from you, you don’t need cover from that observer to (action: Hide) or (action: Sneak)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d25a4e77-0953-4fd8-89dc-172b156d56aa"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
