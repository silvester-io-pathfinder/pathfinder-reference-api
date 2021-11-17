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
    public class LuminousSprite : Template
    {
        public static readonly Guid ID = Guid.Parse("3186fff3-1b82-4252-ba55-56e9f2c194ad");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Luminous Sprite"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dc9afd08-ffb1-448e-a1b7-7e37aada4b54"), Type = TextBlockType.Text, Text = "You glow with magical luminance. You naturally shed light as a torch; this light has the evocation, light, and primal traits. You can extinguish, rekindle, or change the color of this light using a single action, which has the concentrate trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("70e2c334-79f9-4a8e-a9fb-f499a131b240"), "You naturally shed light as a torch; this light has the evocation, light, and primal traits. You can extinguish, rekindle, or change the color of this light using a single action, which has the concentrate trait.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cea192e1-fe59-42c2-a737-08a0143a636c"),
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
