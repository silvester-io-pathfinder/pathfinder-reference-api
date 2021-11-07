using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CutFromTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("956acaf7-3a77-4379-b20f-4658c2dbd833");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cut from the Air",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are the target of a physical ranged Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee6065ea-38a6-434b-943a-d51f96bba365"), Type = TextBlockType.Text, Text = "You can knock aside ranged attacks. You gain a +4 circumstance bonus to AC against the triggering attack. If the attack misses, you knocked or cut it out of the air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21380c87-e88f-45e3-a89f-543bebb2345f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
