using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EchoingChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("17b7230c-746a-4959-a4f5-9d216748b539");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Echoing Channel",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54379539-3011-4d0d-b8aa-7579e72e46d4"), Type = TextBlockType.Text, Text = "When you pull forth positive or negative energy, you also create a smaller pocket of that energy. If the next action you use is to cast a 2-action (spell: harm) or (spell: heal) to heal or damage a single creature, choose one additional creature adjacent to either you or the target. Target that creature with a 1-action version of the same spell. This spell is the same level as the 2-action (spell: harm) or (spell: heal) you cast and doesn’t cost another spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4255a46e-62a2-4015-b7a2-74128756324c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
