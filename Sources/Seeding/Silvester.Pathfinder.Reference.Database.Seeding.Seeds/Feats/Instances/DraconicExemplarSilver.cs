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
    public class DraconicExemplarSilver : Template
    {
        public static readonly Guid ID = Guid.Parse("2f8bb619-218e-4206-8116-0fcd5a5332de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Silver",
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
            yield return new TextBlock { Id = Guid.Parse("66caac01-6994-479b-8efe-80fa832ceaad"), Type = TextBlockType.Text, Text = $"Your scale color and appearance resembles that of a silver dragon." };
            yield return new TextBlock { Id = Guid.Parse("ae5b6fc9-55ac-491c-820f-fd1115d1b3be"), Type = TextBlockType.Text, Text = $"~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("c7b41ca9-f985-4e9a-8088-e382fa56b2ce"), Type = TextBlockType.Text, Text = $"~ Damage Type: Cold" };
            yield return new TextBlock { Id = Guid.Parse("6190e063-66ab-4c07-993a-a89f23933901"), Type = TextBlockType.Text, Text = $"~ Saving Throw: Reflex" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ab979dd-2c2c-4286-b898-94ee6a4764ae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
