using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BanishingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("cfe635a3-ba6e-418e-9d2e-f394cbf8950c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Banishing Blow",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use your champion's reaction, triggered by a fiend within your reach.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6ebc0ea-52ca-43f7-9162-59189796f776"), Type = TextBlockType.Text, Text = "The erratic teleportation magic you experienced in the Kortos Mounts has taught you a few tricks. You attempt an Athletics check to (action: Shove) the fiend that triggered your champion’s reaction; on a success, the target can’t teleport or summon creatures for 1 minute. On a critical success, the target is also stunned 1 and can’t teleport or summon creatures for 1 hour, and if you are on your home plane and the target is a fiend of level 18 or lower from another plane, it is also banished to its home plane. Your multiple attack penalty doesn’t apply to this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("db7e2699-b25a-49b9-a2c3-6fbcb3e2f853"), Feats.Instances.FiendsbaneOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0233fd6b-9f3f-443e-8b18-c244bb347aa5"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
