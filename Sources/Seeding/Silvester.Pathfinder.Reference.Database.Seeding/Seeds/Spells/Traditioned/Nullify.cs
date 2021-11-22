using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Nullify : Template
    {
        public static readonly Guid ID = Guid.Parse("646d30c0-a421-43ef-90f9-d6094ddf3701");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nullify",
                Level = 10,
                Range = "120 feet.",
                Trigger = "A foe within range casts a 9th-level or lower spell.",
                Targets = "The triggering spell.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68d8d8b5-a290-444a-9067-7846d68f4ac5"), Type = TextBlockType.Text, Text = "You instantly destroy the incoming spell, though at the cost of sending magical feedback through your body. You automatically counteract the spell, but the feedback brings you unavoidable harm. You lose 1d8 Hit Points per level of the triggering spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06969b81-1927-4d60-99e6-53fe41c958b4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 118
            };
        }
    }
}
