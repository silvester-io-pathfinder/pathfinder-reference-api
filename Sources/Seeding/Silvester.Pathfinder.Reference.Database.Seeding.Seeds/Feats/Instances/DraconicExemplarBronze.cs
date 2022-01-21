using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBronze : Template
    {
        public static readonly Guid ID = Guid.Parse("faed8333-40e6-46a1-866f-d9abd557d238");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Bronze",
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
            yield return new TextBlock { Id = Guid.Parse("b7d39123-13ef-4389-8c7c-99039369e3c6"), Type = TextBlockType.Text, Text = $"Your scale color and appearance resembles that of a bronze dragon." };
            yield return new TextBlock { Id = Guid.Parse("92dfa1de-9a3f-496f-907c-da1848f642b0"), Type = TextBlockType.Text, Text = $"~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("4597a378-f30e-4a18-8c0b-e3e305e5d3eb"), Type = TextBlockType.Text, Text = $"~ Damage Type: Electricity" };
            yield return new TextBlock { Id = Guid.Parse("db567f6b-b956-48e4-9e5c-8d55019116b5"), Type = TextBlockType.Text, Text = $"~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d87fe6f-6f34-4219-af6d-c437eb04298f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
