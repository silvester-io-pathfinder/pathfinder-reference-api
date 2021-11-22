using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarbedQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("17fd32bb-0fe4-44d1-8bf2-02369b4a680b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Barbed Quills",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are hit with an unarmed strike or a strike with a non-reach melee weapon.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8ccf7d3-5c89-4355-ab8f-d3db302d427d"), Type = TextBlockType.Text, Text = "You break off quills in your attacker's flesh. You deal 1d8 piercing damage to the triggering creature (basic Reflex save using your class DC or spell DC, whichever is higher.) On a critical failure, the creature also takes 1d4 persistent bleed damage as your quills hook into its flesh. At 3rd level, and every 2 levels thereafter, this damage increases by 1d8 and the persistent piercing damage increases by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7adeb64b-e255-44e9-b7aa-196873ebddfa"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
