using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoverFire : Template
    {
        public static readonly Guid ID = Guid.Parse("140f0507-943f-465f-8236-671e23b42ecd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cover Fire",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("195f10a4-cacf-4b74-a085-01661ba09667"), Type = TextBlockType.Text, Text = "You lay down suppressive fire to protect allies by forcing foes to take cover from your wild attacks. Make a firearm or crossbow (action: Strike); the target must decide before you roll your attack whether it will duck out of the way. If the target ducks, it gains a +2 circumstance bonus to AC against your attack, or a +4 circumstance bonus to AC if it has cover. It also takes a –2 circumstance penalty to ranged attack rolls until the end of its next turn. If the target chooses not to duck, you gain a +1 circumstance bonus to your attack roll for that (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b01e2d25-1e7d-4d94-a434-c86c618046a4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
