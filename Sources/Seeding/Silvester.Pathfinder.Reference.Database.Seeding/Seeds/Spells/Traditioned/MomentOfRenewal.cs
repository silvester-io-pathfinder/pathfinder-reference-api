using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MomentOfRenewal : Template
    {
        public static readonly Guid ID = Guid.Parse("69971a2a-214a-487a-8441-e7e11e94ed5e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Moment of Renewal",
                Level = 8,
                Range = "Touch.",
                Targets = "Up to 6 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79a4b64c-bdf3-454f-bd35-035f6638aec4"), Type = TextBlockType.Text, Text = "The targets experience a day’s worth of recovery in an instant. Any detrimental effects that would be gone after 24 hours end, though this doesn’t shorten the duration of any active spells affecting the targets. The targets regain Hit Points and recover from conditions as if they had taken 24 hours of rest, but they do not make their daily preparations again or gain any benefits of rest other than healing. The targets are then temporarily immune for 1 day." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec153656-cfe8-4cfa-940d-c4a3f68d7035"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 353
            };
        }
    }
}
