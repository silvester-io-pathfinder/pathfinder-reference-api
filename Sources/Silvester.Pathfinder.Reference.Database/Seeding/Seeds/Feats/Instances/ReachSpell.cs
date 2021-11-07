using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReachSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("0fe9f438-7e48-4f68-9828-f57d286400aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach Spell",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83f4c017-ac31-476c-8e4a-415900956960"), Type = TextBlockType.Text, Text = "You can extend the range of your spells. If the next action you use is to (activity: Cast a Spell) that has a range, increase that spell’s range by 30 feet. As is standard for increasing spell ranges, if the spell normally has a range of touch, you extend its range to 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7718ede-87b3-4113-9d13-faf42121dfed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
