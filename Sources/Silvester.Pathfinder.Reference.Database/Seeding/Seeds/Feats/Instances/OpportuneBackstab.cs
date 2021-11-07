using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OpportuneBackstab : Template
    {
        public static readonly Guid ID = Guid.Parse("5ad8d761-3819-4354-a5b2-d6525824a356");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Opportune Backstab",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your melee reach is hit by a melee attack from one of your allies.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("691e0880-f828-4798-88b0-f5e918451202"), Type = TextBlockType.Text, Text = "When your enemy is hit by your ally, you capitalize upon the distraction. Make a (action: Strike) against the triggering creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76e1bd7f-7707-4237-b266-515fe772a7be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
