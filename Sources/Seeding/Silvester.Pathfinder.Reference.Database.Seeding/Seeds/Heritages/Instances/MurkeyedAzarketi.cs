using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class MurkeyedAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("5e4897b5-71da-4ec1-9fd9-96bc0dd6677b");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Murkeyed Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c899c56a-0e84-4938-8b1f-b122eb53a933"), Type = TextBlockType.Text, Text = "You live in murky waters and have grown accustomed to life in a low-visibility environment. You need only a successful DC 3 flat check when targeting a concealed creature and a successful DC 9 flat check when targeting a hidden creature." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("6460aec2-ea4e-4ab8-b19a-8cd6ae2e2a23"), "You need only a successful DC 3 flat check when targeting a concealed creature.");
            builder.Manual(Guid.Parse("1a0bc51a-8aa0-432b-a917-829246734031"), "You need only a successful DC 9 flat check when targeting a hidden creature.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8de6df8-bd5f-44c1-9ce3-ffaeabb3ccab"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
