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
    public class DesertElf : Template
    {
        public static readonly Guid ID = Guid.Parse("4b699d38-c3fc-487c-a55b-f8d561897305");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Desert Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2384de9e-93fb-4783-97fa-810053e44209"), Type = TextBlockType.Text, Text = "You live under the desert's blazing heat, gaining incredible resilience to warm environments. You gain fire resistance equal to half your level (minimum 1), and environmental heat effects are one step less extreme for you (incredible heat becomes extreme, extreme heat becomes severe, and so on)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("e781fde4-da69-4586-9d93-54ae5b40649f"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse("73390ab8-1be5-48d4-a67e-36cd662dd2be"), Temperature.Heat, ModifierType.Subtract, 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("582bc4e7-761e-4aa5-92df-16d013bcb2f2"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 25
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
