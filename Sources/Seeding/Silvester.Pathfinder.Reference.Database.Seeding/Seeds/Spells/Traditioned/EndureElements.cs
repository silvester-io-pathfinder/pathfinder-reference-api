using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EndureElements : Template
    {
        public static readonly Guid ID = Guid.Parse("9aa8b0d8-a0d7-4bab-8469-a670ca7820bb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Endure Elements",
                Level = 2,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1afd34c2-61f4-4d49-98fb-8f6f199be704"), Type = TextBlockType.Text, Text = "You shield the target against dangerous temperatures. Choose severe cold or heat. The target is protected from the temperature you chose (but not extreme cold or heat)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b5cf7619-29b1-40a9-aa0c-4d0884f7a729"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0a9d6246-8e6f-497e-b1ab-67b99de926c4"), Type = TextBlockType.Text, Text = "The target is protected from severe cold and heat." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("eedfa17a-1db9-4355-864c-79826eecfbd9"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c62b6908-f402-4c8e-a365-3db67e5aee72"), Type = TextBlockType.Text, Text = "The target is protected from severe cold, severe heat, extreme cold, and extreme heat." }
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
            yield return MagicTraditions.Instances.Divine.ID;
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
                Id = Guid.Parse("14f19d76-cf9d-4170-b530-30b2bfc151e7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 335
            };
        }
    }
}
