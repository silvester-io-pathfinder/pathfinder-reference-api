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
    public class VivaciousGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("0bde2b22-b4ee-484d-9052-6c4b47488624");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Vivacious Gnome"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1a93e6b6-52da-491b-a7e4-baa876b62b1c"), Type = TextBlockType.Text, Text = "You have an incredibly strong connection to the positive energy that flows through the First World, making it harder to attack your life force with negative energy. You gain negative resistance equal to half your level (minimum 1). When you have the doomed condition, the condition affects you as if its value was 1 lower than it actually is (doomed 1 has no effect, doomed 2 causes you to die at dying 3, and so on)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("6d3351ca-626f-4d93-bb25-98972711ffe7"), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifySpecificCondition(Guid.Parse("0bae1533-4907-4bf8-81a4-700b1f9ba1e1"), Conditions.Instances.Doomed.ID, ModifierType.Subtract, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19546d13-b272-4e1e-b480-e82bc2f64a02"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 31
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnome.ID;
        }
    }
}
