using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalAbsorption : Template
    {
        public static readonly Guid ID = Guid.Parse("8d434817-6291-403b-9185-af84a3979ab2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Absorption",
                Level = 102,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("498dfb3d-a1ac-4ea6-bfbc-afe430c0fab8"), Type = TextBlockType.Text, Text = "You absorb elemental energy, which you can release as a powerful counterattack. Choose air, earth, fire, or water. You gain resistance 5 to damage dealt by effects with the chosen elemental trait; if you choose water, you also gain resistance to cold damage. As usual, if a spell has a multiple effects, such as a spell that deals both fire damage and bludgeoning damage with superheated rocks, you gain resistance to only the effects associated with the element you chose. Keep track of how much damage you have prevented with this spell." };
            yield return new TextBlock { Id = Guid.Parse("42827604-86f9-40f7-9d24-d8c1bb8d5a34"), Type = TextBlockType.Text, Text = "As a 2-action activity, which has the concentrate trait and the trait matching the element you chose, you can release the stored energy. This deals damage equal to the amount you�ve stored (maximum 30 damage) to one enemy within 60 feet, with a basic Reflex save. The damage type depends on the element you chose: fire damage for fire; bludgeoning or cold damage for water; bludgeoning or slashing damage for air; or bludgeoning, piercing, or slashing damage for earth. After releasing the energy, the spell ends. If you do not use the stored energy before the spell ends, the energy is lost." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7f27f9f4-3a17-47e3-8f77-230c6882d7ac"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3b1b29fb-e57d-4bf4-9c62-12d42cf9749b"), Type = TextBlockType.Text, Text = "The resistance increases by 5 and the maximum damage increases by 30." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7b5255c5-cc3d-4559-9f9e-6f10a8493b90"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b81293ce-656e-4637-a5af-f2bffc677b55"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 102
            };
        }
    }
}
