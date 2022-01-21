using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ForceCage : Template
    {
        public static readonly Guid ID = Guid.Parse("02016d09-cbe1-48c9-b7ab-e89d7c7a78e6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Force Cage",
                Level = 7,
                Range = "30 feet.",
                Area = "1 cube 20 feet on each side.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efd882f0-0941-4281-b850-a0801d922a62"), Type = TextBlockType.Text, Text = "You create an immobile, invisible prison of sheer force. The cage is a 20-foot cube made of bands of force, each a half inch thick and a half inch apart, that extend to the Ethereal Plane. Each creature in the area where you create the cage must attempt a Reflex save. If such a creature fails, it becomes trapped inside the cage. If it succeeds, it's pushed outside the cage into a space of its choice. If a creature in the area is too big to fit inside the prison, the spell automatically fails." };
            yield return new TextBlock { Id = Guid.Parse("9d14b815-8fdf-4b71-ae1e-5bb0d1047305"), Type = TextBlockType.Text, Text = "The cage has AC 10, Hardness 20, and 40 Hit Points, and it's immune to critical hits and precision damage. A creature capable of passing through the space between the bars (typically a Tiny creature) can leave; all others are confined within. Attacks with a weapon too large to fit between the bars can't pass through the cage, and the bars provide standard cover even against attacks that can pass through the gaps. Spells and breath weapons can pass through the cage uninhibited." };
            yield return new TextBlock { Id = Guid.Parse("252a1aff-f1de-4e56-9cd1-0f92e2f6bf76"), Type = TextBlockType.Text, Text = "Force cage is immune to counteracting effects of its level or lower, but it is automatically destroyed by a disintegrate spell of any level, or by contact with a rod of cancellation (page 262) or sphere of annihilation (Gamemastery Guide 113)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("19b21c91-cbec-41b6-8076-4bd75d028a7f"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("e30b6177-d7b6-4e76-aba2-0d8e10c89dbd"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b14fa2d0-8560-4b40-b185-a9d6ce5f35b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 219
            };
        }
    }
}
