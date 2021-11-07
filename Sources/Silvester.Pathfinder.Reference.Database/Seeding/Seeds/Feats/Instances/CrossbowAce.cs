using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbowAce : Template
    {
        public static readonly Guid ID = Guid.Parse("3472fcb4-6a9d-43e9-8f21-293f4bcd2a9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Ace",
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
            yield return new TextBlock { Id = Guid.Parse("d54dfc9d-2a67-4cbc-a8a0-3418060ea5f6"), Type = TextBlockType.Text, Text = "You have a deep understanding of the crossbow. When you’re wielding a crossbow and use (feat: Hunt Prey) or use (action: Interact) to reload your crossbow, you gain a +2 circumstance bonus to the damage roll on your next (action: Strike) with that crossbow. If the crossbow is a simple crossbow, also increase the damage die size for that attack by one step (page 279). You must make the attack before the end of your next turn or these benefits are lost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdd3ab5a-e939-464c-a1d3-39b079c4549a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
