using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Fly : Template
    {
        public static readonly Guid ID = Guid.Parse("6f7a283d-9e82-4c37-b0f5-adef6633636c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fly",
                Level = 4,
                Range = "Touch.",
                Duration = "5 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3959e792-180e-4911-b739-408651fb1c8d"), Type = TextBlockType.Text, Text = "The target can soar through the air, gaining a fly Speed equal to its Speed or 20 feet, whichever is greater." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d2ba1365-b169-405b-9120-6725445f6428"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5de30fd5-357a-4889-86cc-7d249b25cc72"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
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
                Id = Guid.Parse("8ffa0196-dea0-4a98-ab93-53e590bcf4a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 339
            };
        }
    }
}
