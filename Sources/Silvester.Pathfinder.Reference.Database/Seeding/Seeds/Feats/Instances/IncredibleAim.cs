using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleAim : Template
    {
        public static readonly Guid ID = Guid.Parse("cf25facb-b19e-4ba3-ad43-39068a6e49ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Aim",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86b93771-1b3f-480c-8b9c-15c15cda8749"), Type = TextBlockType.Text, Text = "By spending a moment to focus, you can ensure your attack strikes true. Make a ranged weapon (Action: Strike). On this (Action: Strike), you gain a +2 circumstance bonus to the attack roll and ignore the target’s concealed condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ead77a3a-806d-4053-a07f-321b80773b85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
