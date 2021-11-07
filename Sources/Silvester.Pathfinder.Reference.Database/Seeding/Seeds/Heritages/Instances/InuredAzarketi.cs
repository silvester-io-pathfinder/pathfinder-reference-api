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
    public class InuredAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Inured Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors had to survive in polluted water that made every breath noxious. You gain poison resistance equal to half your level (minimum 1). Furthermore, you can survive outside of water for 72 hours before you begin to suffocate." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.Manual(Guid.Parse(""), "You can survive outside of water for 72 hours before you begin to suffocate.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AzarketiAncestryWebSupplement.ID,
                Page = 3
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
