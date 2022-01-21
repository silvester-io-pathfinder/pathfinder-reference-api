using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StormOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("94086e1d-52d0-4b8f-89c6-af6597fcd75c");

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
            yield return new TextBlock { Id = Guid.Parse("fe040b5e-64f9-4328-ae35-e7122e26a024"), Type = TextBlockType.Text, Text = "A massive storm cloud forms in the air in a 360-foot burst. Beneath it, rain begins to fall, and gales impose a –4 circumstance penalty to physical ranged attacks and weapon ranged attacks, and the air in the area becomes greater difficult terrain for flying creatures. When you Cast this Spell and the first time each round you Sustain the Spell, you can choose one of the following storm effects. You can't choose the same effect twice in a row." };
            yield return new TextBlock { Id = Guid.Parse("e935ce38-d203-4bac-94fd-35d15e4e4c99"), Type = TextBlockType.Enumeration, Text = "Acid Rain - Each creature in the storm takes 4d8 acid damage with no saving throw." };
            yield return new TextBlock { Id = Guid.Parse("cc5d3c24-f5f3-4ede-a9aa-6baa4934785d"), Type = TextBlockType.Enumeration, Text = "Hail - The storm deals 4d10 bludgeoning damage to creatures beneath it(basic Fortitude save)." };
            yield return new TextBlock { Id = Guid.Parse("1264c103-896b-496b-a32d-47c76bbfa42c"), Type = TextBlockType.Enumeration, Text = "Lightning - Up to 10 bolts of lightning strike down, targeting creatures of your choice in the storm. No more than one bolt can target any one creature. Each bolt deals 7d6 electricity damage (basic Reflex save)." };
            yield return new TextBlock { Id = Guid.Parse("0f9e8d44-5d43-4b60-9926-1d811b1f98fb"), Type = TextBlockType.Enumeration, Text = "Rain and Wind - Heavy rain and whipping wind reduce visibility and mobility, making the area under the storm cloud difficult terrain and making everything seen within or through the area concealed." };
            yield return new TextBlock { Id = Guid.Parse("1c86472c-fa6f-45e6-aaf7-e4cd5bef036e"), Type = TextBlockType.Enumeration, Text = "Thunderclap - Each creature in the storm must succeed at a Fortitude save or be deafened for 10 minutes. A creature that succeeds is temporarily immune to thunderclaps from storm of vengeance for 1 hour." };
        }

         public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("72ca3ccf-136e-44d9-8877-790047e75b06"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f3d16c56-6aca-4400-91cc-b7b8771504e9"), Type = TextBlockType.Text, Text = "The range increases to 2,200 feet, and the cloud is a 1,000-foot burst." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("65913682-34e1-4116-bdcf-b6ab156471d6"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("e339ff12-212f-4699-a098-0a8d77bc45bf"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("fe3680e2-bb24-43c1-a1c1-13cd8cf058fd"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("035ffe53-02af-4a07-bb1b-05afd00afcf2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
