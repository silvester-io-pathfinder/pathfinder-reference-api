using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationEnhancedResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("e34ecc1f-d2c5-4df0-a36a-9170965ae88d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Enhanced Resistance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e910e26-bc10-4948-91a2-e82bdf785fbb"), Type = TextBlockType.Text, Text = "You’ve improved upon your initial modification’s ability to resist damage. The resistance from your initial armor modification adds your full level, instead of half your level (for instance, phlogistonic regulator’s resistance would increase to your level). If you have more than one initial modification that gives resistance, choose which one this applies to." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f317051-459a-42f1-8105-e25e0992d8a2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
