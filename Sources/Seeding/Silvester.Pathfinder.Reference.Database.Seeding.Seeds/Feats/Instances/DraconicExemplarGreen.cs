using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarGreen : Template
    {
        public static readonly Guid ID = Guid.Parse("bba0357d-6750-4316-8374-974250ecdafc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Green",
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
            yield return new TextBlock { Id = Guid.Parse("9aac6d1e-fdc8-4cf3-a51c-388ca2a2270a"), Type = TextBlockType.Text, Text = $"Your scale color and appearance resembles that of a green dragon." };
            yield return new TextBlock { Id = Guid.Parse("ab9cf81e-07ae-49f4-8920-31d4bd852be6"), Type = TextBlockType.Text, Text = $"~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("9e66f81b-ef3b-4b03-9d1e-307a1f5c5907"), Type = TextBlockType.Text, Text = $"~ Damage Type: Poison" };
            yield return new TextBlock { Id = Guid.Parse("55256155-18f5-42ee-8adf-d681bc57760d"), Type = TextBlockType.Text, Text = $"~ Saving Throw: Fortitude" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("394feac9-1be5-49cd-82b0-aa2a19ae3dc0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
