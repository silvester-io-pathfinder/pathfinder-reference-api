using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OneiricMire : Template
    {
        public static readonly Guid ID = Guid.Parse("564940df-71de-4651-b36e-c73e4d062157");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Oneiric Mire",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "20-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b781119-9814-4eb8-8fa4-00c9e0ea27c5"), Type = TextBlockType.Text, Text = "You shroud an area in illusory dreamstuff, making the ground look and feel like a deep mire or quicksand. Ground in the area is difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("8e945910-4994-4aec-9280-0effaf2e97b2"), Type = TextBlockType.Text, Text = "Each creature in the area when the spell is cast, or that enters the area, must attempt a Will save. On a failure, it believes it's being pulled down by the earth, taking a -10-foot circumstance penalty to its Speeds. On a critical failure, it's also immobilized. In addition to the normal actions to Escape, at the end of an affected creature's turn, it can attempt a Will save, removing the effects on a success. On a critical success at any Will save made against oneiric mire, the creature fully disbelieves the illusion and no longer needs to make Will saves to risk a Speed penalty or being immobilized, though the area is still difficult terrain." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7560cc3e-a890-4868-94b8-870f7e337b59"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 119
            };
        }
    }
}
