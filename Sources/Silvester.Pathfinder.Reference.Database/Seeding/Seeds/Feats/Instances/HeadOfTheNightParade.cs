using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeadOfTheNightParade : Template
    {
        public static readonly Guid ID = Guid.Parse("f3919423-44e2-45bb-8128-a0103610e8a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Head of the Night parade",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3b48d4d-5573-438a-a9e1-6e97407dfa9b"), Type = TextBlockType.Text, Text = "You remember the revelry of the Night Parade and call them to your aid in a riotous display. You (action: Perform) and cast 8th-level (spell: mad monkeys) three times, except that the spell calls various apparitions such as dancing tsukumogami or drinking oni rather than monkeys. Each casting can produce a different kind of mischief. You can Sustain all three Spells each round using a single (action: Perform) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a86f1d1b-3a7d-4fd9-abea-faaa5d197f15"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
