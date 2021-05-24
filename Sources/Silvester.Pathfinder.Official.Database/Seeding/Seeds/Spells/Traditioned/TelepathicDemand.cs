using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TelepathicDemand : Template
    {
        public static readonly Guid ID = Guid.Parse("e3d0c355-6a89-4b7a-91c5-5aba4d45ff64");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telepathic Demand",
                Level = 9,
                Range = "Planetary.",
                Duration = "Varies.",
                Targets = "1 creature you've telepathically contacted before.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72766628-c338-4240-8429-5b9f4fdd5d13"), Type = TextBlockType.Text, Text = "You send the target a message of 25 words or fewer, and it can respond immediately with its own message of 25 words or fewer. Your message is insidious and has the effect of suggestion (page 374), with the message substituting for the spoken suggestion. On a successful save, the target is temporarily immune for 1 day, and on a critical success, the target is temporarily immune for 1 month. You can target a creature only if you have previously been in telepathic contact with it before, such as via the telepathy spell." };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25e51f0b-ea54-49ea-9206-ecc3c1dd279b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
