using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Jump : Template
    {
        public static readonly Guid ID = Guid.Parse("787457e2-ad8a-4ae5-96e5-48225cf53686");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Jump",
                Level = 1,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12e8e61c-0c25-401d-989e-1d9870807efa"), Type = TextBlockType.Text, Text = "Your legs surge with strength, ready to leap high and far. You jump 30 feet in any direction without touching the ground. You must land on a space of solid ground within 30 feet of you, or else you fall after using your next action." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("00aa086e-4977-4c45-b139-e15b8ffe4074"), 
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("104e9c3d-aee2-48b1-a511-00bcebc47c0c"), Type = TextBlockType.Text, Text = "The range becomes touch, the target changes to one touched creature, and the duration becomes 1 minute, allowing the target to jump as described whenever it takes the Leap action." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8a1faa4-cdb3-4a0f-9311-06cefee2d456"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
