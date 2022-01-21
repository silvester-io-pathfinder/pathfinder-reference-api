using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Pixie : Template
    {
        public static readonly Guid ID = Guid.Parse("dd76b2d0-b521-4183-a42d-8c96fbfc290d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Pixie"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b170f96f-13c9-48d4-9954-4afa3ecec46b"), Type = TextBlockType.Text, Text = "You are larger than other sprites. Instead of Tiny, your size is Small." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse("60f04f59-d87b-459c-bd75-1ac0ef2fbce8"), AncestrySizes.Instances.Small.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a21b39c-2363-4211-a164-b4bc0976015d"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 129
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Sprite.ID;
        }
    }
}
