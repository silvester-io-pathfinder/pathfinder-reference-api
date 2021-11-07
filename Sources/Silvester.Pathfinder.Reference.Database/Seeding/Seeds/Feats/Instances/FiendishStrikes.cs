using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("a8287cd8-6420-4e61-8b39-fccc2d1d3caf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Strikes",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b66e5cbb-5cd5-4455-9d73-262a4f74c656"), Type = TextBlockType.Text, Text = "Your festering connection to the forces of evil infuses your weapons with debilitating malevolence, tearing down creatures of good with every attack. All your weapon and unarmed (action: Strikes | Strike) deal 1 additional evil damage and have the (trait: evil) and (trait: magical) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d761cfad-62c9-458e-bf1a-a2f618992ec1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
