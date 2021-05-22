using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Disappearance : Template
    {
        public static readonly Guid ID = Guid.Parse("614267ca-482a-4435-bcea-127594ea342f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disappearance",
                Level = 8,
                Range = "Touch.",
                Targets = "1 creature.",
                Duration = "10 minutes",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d77c0d6-b1c3-4787-a506-6f1b01bfdce1"), Type = Utilities.Text.TextBlockType.Text, Text = "You shroud a creature from others’ senses. The target becomes undetected, not just to sight but to all senses, allowing the target to count as invisible no matter what precise and imprecise senses an observer might have. It’s still possible for a creature to find the target by Seeking, looking for disturbed dust, hearing gaps in the sound spectrum, or finding some other way to discover the presence of an otherwise-undetectable creature" };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7c08760-c065-42b3-9e4a-df39ec5a2f8e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
