using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReachBeyond : Template
    {
        public static readonly Guid ID = Guid.Parse("ebca4a77-e39f-40ca-a868-86c3385dab0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach Beyond",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1765ac6e-8042-4a67-9ccc-3c267f0e75ef"), Type = TextBlockType.Text, Text = "You&#39;ve learned to move your spiritual energy past yourself to attack spirits where others can&#39;t. You can make melee (action: Strikes | Strike) against incorporeal creatures that are inside solid objects as long as the object is within your reach. An incorporeal creature inside of a solid object is hidden, requiring you to succeed at a DC 11 flat check when you target it. You can spend an action, which has the (trait: concentrate) trait, to focus on a creature inside of a solid object. If you do, the next melee (action: Strike) you make this turn requires you to succeed at only a DC 6 flat check to affect the creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("046a6306-4d33-40f0-861c-e103c914902b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
