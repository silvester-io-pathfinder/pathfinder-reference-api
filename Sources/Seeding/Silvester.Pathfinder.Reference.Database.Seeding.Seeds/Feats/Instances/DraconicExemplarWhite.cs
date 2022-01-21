using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarWhite : Template
    {
        public static readonly Guid ID = Guid.Parse("8d01929f-7ad3-4038-87b8-2892b0854437");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - White",
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
            yield return new TextBlock { Id = Guid.Parse("1207cabd-a7db-46ae-83fa-6e18b8cc3173"), Type = TextBlockType.Text, Text = $"Your scale color and appearance resembles that of a white dragon." };
            yield return new TextBlock { Id = Guid.Parse("e90b9417-3c74-48a6-897e-efbed30b4f35"), Type = TextBlockType.Text, Text = $"~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("1893b24e-f5bb-4cd7-8950-5c5bab08d777"), Type = TextBlockType.Text, Text = $"~ Damage Type: Cold" };
            yield return new TextBlock { Id = Guid.Parse("a64f41cc-b567-40d2-939d-d81ad2e1a487"), Type = TextBlockType.Text, Text = $"~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("986ef8e0-c9bd-461b-a8e9-aaf3f0aea803"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
