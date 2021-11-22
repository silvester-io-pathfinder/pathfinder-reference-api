using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptiveStance : Template
    {
        public static readonly Guid ID = Guid.Parse("3cf51bf2-76bf-4908-99e6-305b621b3188");

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
            yield return new TextBlock { Id = Guid.Parse("b38785a4-c791-4a1c-8577-7963f2be0606"), Type = TextBlockType.Text, Text = "The slightest distraction can provoke your wrath, and you're prepared to foil enemies' actions. As long as you are in this stance, you can use (feat: Attack of Opportunity) when a creature within your reach uses a (trait: concentrate) action, in addition to (trait: manipulate) and (trait: move) actions. Furthermore, you disrupt a triggering (trait: concentrate) or (trait: manipulate) action if your (action: Strike) hits (not only if it's a critical hit)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daf4e280-08fa-41da-a3c0-de29acbf0521"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
