using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptiveStance : Template
    {
        public static readonly Guid ID = Guid.Parse("7af0233b-17b1-43f7-8236-ef1c57734302");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disruptive Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5b8e277-ca24-4226-841d-4116582d9126"), Type = TextBlockType.Text, Text = "The slightest distraction can provoke your wrath, and you’re prepared to foil enemies’ actions. As long as you are in this stance, you can use (feat: Attack of Opportunity) when a creature within your reach uses a (trait: concentrate) action, in addition to (trait: manipulate) and (trait: move) actions. Furthermore, you disrupt a triggering (trait: concentrate) or (trait: manipulate) action if your (action: Strike) hits (not only if it’s a critical hit)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad760bb5-464e-45b6-a3d4-ee6260ca75ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
