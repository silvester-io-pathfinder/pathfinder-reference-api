using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConductEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("136bbf55-a501-49c5-9221-826baa27c121");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conduct Energy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ded2386-9297-4c5c-a333-244309814643"), Type = TextBlockType.Text, Text = "You channel energy into your weapon. The weapon deals 1 additional damage per weapon damage die until the start of your next turn. This damage type matches the trait of the triggering action or spell. If your triggering action or spell had multiple eligible traits, you select one of those traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0340c70c-eae3-4e3a-9e3c-33a2e7399b1a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
