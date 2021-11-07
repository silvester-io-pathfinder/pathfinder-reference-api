using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersAim : Template
    {
        public static readonly Guid ID = Guid.Parse("ffaa7f48-d803-49a8-aefd-6341e880aee6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunter's Aim",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a364c12-d8aa-404d-9ef8-cd9764d33b10"), Type = TextBlockType.Text, Text = "When you focus on aiming, your attack becomes particularly accurate. Make a ranged weapon (action: Strike) against your hunted prey. On this (action: Strike), you gain a +2 circumstance bonus to the attack roll and ignore your prey’s concealed condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6b8c9ef-18ee-4187-aac2-ea3261158650"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
