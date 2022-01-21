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
    public class ShapewroughtFleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("28484f1e-b0f1-4cc9-bc46-43881cd9159b");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Shapewrought Fleshwarp"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("12b29670-e6a8-4d0f-8023-a00604bac56e"), Type = TextBlockType.Text, Text = "A victim of fleshwarping, you likely bear loose flesh, bony spurs, or features of inhuman creatures sprouting from your skin. You have nevertheless turned the psychic toll of your transformation into a strength. You gain resistance to mental damage equal to half your level (minimum 1)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("620d539e-df6d-455d-bdad-87e3e502ce33"), DamageTypes.Instances.Mental.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c1a26ab-a734-43ad-a741-361f31a2c504"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 91
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Fleshwarp.ID;
        }
    }
}
