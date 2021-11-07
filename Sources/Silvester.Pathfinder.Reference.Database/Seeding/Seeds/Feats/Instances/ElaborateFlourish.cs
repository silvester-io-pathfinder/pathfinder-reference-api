using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElaborateFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("6b2462ef-7a8e-4624-88d2-86a23662d8b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elaborate Flourish",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98c05a65-e8bc-471b-a423-9d6366c9b211"), Type = TextBlockType.Text, Text = "You embellish your spellcasting with entrancing flourishes and grand pronouncements, making it harder to identify or counter. If the next action you use is to (activity: Cast a Spell), creatures with the ability to (activity: Cast that Spell | Cast a Spell) don’t automatically know what the spell is. In addition, creatures that witness your spellcasting take a -2 circumstance penalty to checks to identify the spell with (action: Recall Knowledge) and checks to counteract the spell during its casting (such as with (feat: Counterspell))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6dd2aac3-ed63-409e-9902-42ebb4c15833"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
