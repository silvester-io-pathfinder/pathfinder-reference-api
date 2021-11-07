using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stonewalker : Template
    {
        public static readonly Guid ID = Guid.Parse("53123a83-bfca-4021-a42e-405c0985b840");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stonewalker",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c43b8f88-aefd-4dde-ab39-2992e1713237"), Type = TextBlockType.Text, Text = "You have a deep reverence for and connection to stone. You gain (spell: meld into stone) as a 3rd-level divine innate spell that you can cast once per day." };
            yield return new TextBlock { Id = Guid.Parse("0c048ff2-ebd6-422e-a403-eb55c0257fe0"), Type = TextBlockType.Text, Text = "If you have the (feat: Stonecunning) dwarf ancestry feat, you can attempt to find unusual stonework and stonework traps that require legendary proficiency in Perception. If you have both (feat: Stonecunning) and legendary proficiency in Perception, when you’re not (action: Seeking | Seek) and the GM rolls a secret check for you to notice unusual stonework, you keep the bonus from (feat: Stonecunning) and don’t take the -2 circumstance penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f41d4387-06c2-427e-9b0a-697a4470de64"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
