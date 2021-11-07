using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombatGrab : Template
    {
        public static readonly Guid ID = Guid.Parse("a4bc6dcf-3cf7-479f-ac1d-fdfc9863f315");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Grab",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a876726-44a7-404e-a04d-6bae26573ba2"), Type = TextBlockType.Text, Text = "You swipe at your opponent and grab at them. Make a melee (Action: Strike) while keeping one hand free. If the (Action: Strike) hits, you grab the target using your free hand. The creature remains grabbed until the end of your next turn or until it (Action: Escapes | Escape), whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("434ce8ef-ecf1-4bcc-b909-ee0716a48cbd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
