using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HaughtyObstinacy : Template
    {
        public static readonly Guid ID = Guid.Parse("0bc5c110-94e7-4461-8651-dc547583c963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Haughty Obstinacy",
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
            yield return new TextBlock { Id = Guid.Parse("d312fcba-57f1-4826-8ce1-2ccfc4df7354"), Type = TextBlockType.Text, Text = "Your powerful ego makes it harder for others to order you around. If you roll a success on a saving throw against a mental effect that attempts to directly control your actions, you critically succeed instead. If a creature rolls a failure on a check to (action: Coerce) you using Intimidation, it gets a critical failure instead (so it can’t try to (action: Coerce) you again for 1 week)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("013d65ea-4b1b-481f-a330-273ce502eb76"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
