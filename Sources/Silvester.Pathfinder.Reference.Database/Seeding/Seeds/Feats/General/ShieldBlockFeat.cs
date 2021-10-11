using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ShieldBlockFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("50c8d9fd-a34f-4c63-b3be-4881a00f1717");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield Block",
                Level = 1,
                Trigger = "While you have your shield raised, you would take damage from a physical attack.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("684d01f2-c928-4b0b-925e-9081d18b68b3"), Type = TextBlockType.Text, Text = "You snap your shield in place to ward off a blow. Your shield prevents you from taking an amount of damage up to the shield�s Hardness. You and the shield each take any remaining damage, possibly breaking or destroying the shield." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddcb1c27-dffe-4c2c-baf3-8a781ab4395a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 266
            };
        }
    }
}
