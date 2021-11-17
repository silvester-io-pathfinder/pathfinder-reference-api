using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShieldingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("359cda8e-dd38-4976-ba08-97e3c46137a3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shielding Strike",
                Level =1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("678f2ef6-c353-4585-89fd-3f26d45dd13d"), Type = TextBlockType.Text, Text = "As you attack a foe, warding magic transforms your momentum into action and lifts your shield. Make a melee Strike. You can then either Raise your Shield if you're wielding one or cast shield if you have the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magus.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e79124b2-a1fe-47ed-a8ac-57e09bf6d34e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
