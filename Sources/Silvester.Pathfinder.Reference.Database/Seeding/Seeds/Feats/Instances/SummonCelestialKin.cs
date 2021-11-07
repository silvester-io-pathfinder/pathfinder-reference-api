using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonCelestialKin : Template
    {
        public static readonly Guid ID = Guid.Parse("3edaff91-448f-4592-870b-96ead44962a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Celestial Kin",
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
            yield return new TextBlock { Id = Guid.Parse("1200fff7-34fe-4f6a-b8b8-d4248517bc7f"), Type = TextBlockType.Text, Text = "You have a connection to the celestial realms, allowing you to summon a celestial ally. Once per day, you can cast (spell: summon celestial) as a 5th-level divine innate spell, but the celestial summoned must be from the same category as your own lineage, such as a creature with the angel trait if you are angelkin." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAncestry(Guid.Parse("c7d5437a-529d-418f-8c46-1fe8ae802faa"), Ancestries.Instances.Aasimar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51072464-ea66-44d2-98ee-93b0a185dc4f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
