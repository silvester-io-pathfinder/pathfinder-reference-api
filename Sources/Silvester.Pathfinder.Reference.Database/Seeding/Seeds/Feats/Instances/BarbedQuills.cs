using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarbedQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("dcbe7f2e-e2b5-4e15-b1b3-e80489c2f177");

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
            yield return new TextBlock { Id = Guid.Parse("18b3d9d8-3fff-4b20-bc9b-98da8e5f74bc"), Type = TextBlockType.Text, Text = "You break off quills in your attacker’s flesh. You deal 1d8 piercing damage to the triggering creature (basic Reflex save using your class DC or spell DC, whichever is higher.) On a critical failure, the creature also takes 1d4 persistent bleed damage as your quills hook into its flesh. At 3rd level, and every 2 levels thereafter, this damage increases by 1d8 and the persistent piercing damage increases by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("295a5d52-81f1-4dd5-8cba-a4e807342fd0"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
