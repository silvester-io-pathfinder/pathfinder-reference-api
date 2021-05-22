using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class StormOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Storm of Vengeance",
                Level = 9,
                Range = "800 feet.",
                Area = "360-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Text, Text = "A massive storm cloud forms in the air in a 360-foot burst. Beneath it, rain begins to fall, and gales impose a –4 circumstance penalty to physical ranged attacks and weapon ranged attacks, and the air in the area becomes greater difficult terrain for flying creatures. When you Cast this Spell and the first time each round you Sustain the Spell, you can choose one of the following storm effects. You can’t choose the same effect twice in a row." };
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Enumeration, Text = "Acid Rain - Each creature in the storm takes 4d8 acid damage with no saving throw." };
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Enumeration, Text = "Hail - The storm deals 4d10 bludgeoning damage to creatures beneath it(basic Fortitude save)." };
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Enumeration, Text = "Lightning - Up to 10 bolts of lightning strike down, targeting creatures of your choice in the storm. No more than one bolt can target any one creature. Each bolt deals 7d6 electricity damage (basic Reflex save)." };
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Enumeration, Text = "Rain and Wind - Heavy rain and whipping wind reduce visibility and mobility, making the area under the storm cloud difficult terrain and making everything seen within or through the area concealed." };
            yield return new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Enumeration, Text = "Thunderclap - Each creature in the storm must succeed at a Fortitude save or be deafened for 10 minutes. A creature that succeeds is temporarily immune to thunderclaps from storm of vengeance for 1 hour." };
        }

         public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"), Type = TextBlockType.Text, Text = "The range increases to 2,200 feet, and the cloud is a 1,000-foot burst." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32ddcaf9-0e29-4a0e-a1ba-61bf1b4ccc30"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
