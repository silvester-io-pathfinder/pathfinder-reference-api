using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TelepathicBond : Template
    {
        public static readonly Guid ID = Guid.Parse("c6625e80-92f2-44d9-8ad7-671ae34c1035");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telepathic Bond",
                Level = 5,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "You and up to 4 willing creatures touched.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7cf3c40a-ccfd-4af5-965b-001b0186a22b"), Type = TextBlockType.Text, Text = "The targets can communicate telepathically with any or all of the other targets from any point on the same planet." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24a8a6fe-033c-4add-a359-a01e722ca507"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
