using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResilientTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("cd870de0-0444-4ae0-b737-fa0c9ee5594e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resilient Touch",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21c8bd33-50f5-4f74-86b1-61d79eadfe83"), Type = TextBlockType.Text, Text = "Your healing energies create an aura of protection that defends your allies against more than just blades and arrows. An ally that recovers Hit Points from your (spell: lay on hands) gains a +1 status bonus to their saving throws until the end of their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("798e0593-f6e3-4711-8e8b-3f4b39ccf5f0"), Spells.Instances.LayOnHands.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da0b67d0-2495-41aa-991a-f19bb5292e50"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
