using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonstrousPeacemaker : Template
    {
        public static readonly Guid ID = Guid.Parse("ba354c44-ed22-4a3e-b6f6-56d42747368a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monstrous Peacemaker",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47d37e1f-48a9-4e67-b530-80b9cac9a2b7"), Type = TextBlockType.Text, Text = "Your dual human and orc nature has given you a unique perspective, allowing you to bridge the gap between humans and the many intelligent creatures in the world that humans consider monsters. You gain a +1 circumstance bonus to Diplomacy checks against non-humanoid intelligent creatures and against humanoids that are marginalized in human society (at the GM’s discretion, but typically at least including giants, goblins, kobolds, and orcs). You also gain this bonus on Perception checks to (action: Sense the Motives | Sense Motive) of such creatures." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47d4c85d-f8a2-4aba-99d9-9e534457a1f3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
