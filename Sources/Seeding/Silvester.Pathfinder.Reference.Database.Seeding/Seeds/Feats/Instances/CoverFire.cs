using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoverFire : Template
    {
        public static readonly Guid ID = Guid.Parse("29ec98b1-e6f0-433b-ac95-cc59f73fe8cd");

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
            yield return new TextBlock { Id = Guid.Parse("56be9ecc-ed7e-4f9e-ab47-16763a61fadd"), Type = TextBlockType.Text, Text = "You lay down suppressive fire to protect allies by forcing foes to take cover from your wild attacks. Make a firearm or crossbow (action: Strike); the target must decide before you roll your attack whether it will duck out of the way. If the target ducks, it gains a +2 circumstance bonus to AC against your attack, or a +4 circumstance bonus to AC if it has cover. It also takes a –2 circumstance penalty to ranged attack rolls until the end of its next turn. If the target chooses not to duck, you gain a +1 circumstance bonus to your attack roll for that (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55178438-fa0c-49ab-83be-8f002a6a00bd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
