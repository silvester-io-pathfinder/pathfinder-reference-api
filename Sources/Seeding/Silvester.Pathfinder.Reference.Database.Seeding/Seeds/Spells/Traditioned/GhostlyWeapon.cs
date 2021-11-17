using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GhostlyWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("08388049-8e6b-4622-a4fd-c6f6d5d7e335");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ghostly Weapon",
                Level = 3,
                Range = "Touch.",
                Duration = "5 minutes.",
                Targets = "1 non-magical weapon that is either unattended or wielded by you or a willing ally.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae60b301-4edf-450c-8c89-f943631706b0"), Type = TextBlockType.Text, Text = "The target weapon becomes translucent and ghostly, and it can affect material and incorporeal creatures and objects. It can be wielded by a corporeal or incorporeal creature and gains the effects of the ghost touch property rune." };
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e941be7a-b4df-4b66-a813-3646e7d65510"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
