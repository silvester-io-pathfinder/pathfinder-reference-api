using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RoughRider : Template
    {
        public static readonly Guid ID = Guid.Parse("053c81df-4579-4ec9-b604-d24091ce4c41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rough Rider",
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
            yield return new TextBlock { Id = Guid.Parse("ccb7c867-48d9-42ab-8152-d3194ac97b11"), Type = TextBlockType.Text, Text = "You are especially good at riding traditional goblin mounts. You gain the (feat: Ride) feat, even if you don’t meet the prerequisites. You gain a +1 circumstance bonus to Nature checks to use (action: Command an Animal) on a goblin dog or wolf mount. You can always select a wolf as your animal companion, even if you would usually select an animal companion with the mount special ability, such as for a champion’s steed ally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48a23a86-87b5-4f03-bc5e-ee782922a16c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
