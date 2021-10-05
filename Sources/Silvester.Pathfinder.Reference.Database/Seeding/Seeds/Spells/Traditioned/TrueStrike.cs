using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TrueStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("82e5887d-a419-48a4-9c65-b795b15cd7c2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "True Strike",
                Level = 1,
                Duration = "Until the end of your turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70f45247-dee7-42ef-81fe-8152eed0a354"), Type = TextBlockType.Text, Text = "A glimpse into the future ensures your next blow strikes true. The next time you make an attack roll before the end of your turn, roll the attack twice and use the better result. The attack ignores circumstance penalties to the attack roll and any flat check required due to the target being concealed or hidden." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d391b2ca-31f7-4e51-b2fd-221eb32ac0a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
