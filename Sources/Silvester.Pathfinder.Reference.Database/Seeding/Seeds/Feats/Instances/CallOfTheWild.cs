using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOfTheWild : Template
    {
        public static readonly Guid ID = Guid.Parse("54436bbb-10c5-4e25-b043-f8332fa108c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call of the Wild",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b02f121-5974-413e-95be-f856ad84df75"), Type = TextBlockType.Text, Text = "You call upon the creatures of nature to come to your aid. You can spend 10 minutes in concert with nature to replace one of the spells you’ve prepared in one of your druid spell slots with a (spell: summon animal) or (spell: summon plant or fungus) spell of the same level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9ceff48-b441-4c89-9a48-6d24c6164446"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
