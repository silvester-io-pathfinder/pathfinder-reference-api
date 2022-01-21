using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RavenousPortal : Template
    {
        public static readonly Guid ID = Guid.Parse("21fbbcb7-2ac8-45d1-812c-cb37da4f3483");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ravenous Portal",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 hour.",
                Targets = "1 door no more than 10 feet tall and 5 feet wide.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffaf51a6-c516-4065-bcf8-2a351ec58a56"), Type = TextBlockType.Text, Text = "You place a ward upon the door that triggers when a creature attempts to open, unlock, or destroy the door. When that happens, the door transforms into a mimic (Bestiary 236) that can�t move and is hostile to all creatures. When Casting the Spell, you designate yourself and up to 10 other creatures of your choice; these creatures don�t trigger the ward, and the mimic is helpful to them instead of hostile. No effect can move the mimic unless it�s also capable of moving the entire door. Once the door transforms into a mimic, it attacks creatures in its reach for up to 1 minute, and then the spell ends. If the mimic is killed before that time, the spell ends and the door returns to its normal form." };
            yield return new TextBlock { Id = Guid.Parse("4505f722-cb19-47e6-aa13-f56f67d30039"), Type = TextBlockType.Text, Text = "While turned into a mimic, the door can�t be opened, unlocked, or bypassed�not even by the designated creatures. It�s a creature, not a door, during that time. When the spell ends, the door returns to the state it was in before the ward was triggered." };
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
            builder.Add(Guid.Parse("2936ee34-1dc5-45eb-9473-46aec8b87928"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0efa62f6-c592-4cdd-97e4-30f6fb8fad21"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 124
            };
        }
    }
}
