using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgileGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("6182ea2e-5bfd-408a-8754-3809faca33fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agile Grace",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a5ed6fc-bb3b-4d8b-afc5-d5dc51d38d49"), Type = TextBlockType.Text, Text = "Your graceful moves with agile weapons are beyond compare. Your multiple attack penalty with (trait: agile) weapons and (trait: agile) unarmed attacks becomes -3 for your second attack and -6 for subsequent attacks (rather than -4 and -8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7072319-4bb5-411c-856a-5b419556fc40"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
