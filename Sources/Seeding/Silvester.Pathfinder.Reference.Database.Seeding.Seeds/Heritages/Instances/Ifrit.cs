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
    public class Ifrit : Template
    {
        public static readonly Guid ID = Guid.Parse("85ce13c4-37d8-4730-ac8f-9818fe700ab8");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Ifrit"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7e5955b3-1a73-40a0-841f-c097398a5774"), Type = TextBlockType.Text, Text = "You descend from fire elementals or bear the mark of the Inner Spheres, and your features illustrate the influence that elemental fire has over you. You gain the ifrit trait, in addition to the traits from your ancestry. You gain resistance to fire equal to half your level (minimum 1), and you treat environmental heat effects as if they were one step less severe (incredible heat becomes extreme, extreme heat becomes severe, and so on). You can choose from ifrit feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("d516ac39-32fe-4452-8387-7db3e4b8fc59"), Traits.Instances.Ifrit.ID);
            builder.GainSpecificDamageResistance(Guid.Parse("a8477c80-5322-4ac1-bbf9-f14d0fea82b2"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse("c3ac2c41-2482-4ffc-9e64-cfb5f4daa1ce"), Temperature.Heat, ModifierType.Subtract, modifier: 1);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("435f2d1d-3dd1-4a96-adc3-e00f5a063769"), Traits.Instances.Ifrit.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6947849a-015d-4a3c-9f98-4c99175581b3"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 101
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
