using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TimeStop : Template
    {
        public static readonly Guid ID = Guid.Parse("bdc919fe-cf21-4155-9b1a-8022d338067c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Time Stop",
                Level = 10,
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f449dccf-c2b6-46a5-bda9-b6f8680bcca4"), Type = TextBlockType.Text, Text = "You temporarily stop time for everything but yourself, allowing you to use several actions in what appears to others to be no time at all. Immediately after casting time stop, you can use up to 9 actions in 3 sets of up to 3 actions each. After each set of actions, 1 round passes, but only for you, effects specifically targeting or affecting you, and effects you create during the stoppage. All other creatures and objects are invulnerable to your attacks, and you can’t target or affect them with anything. Once you have finished your actions, time begins to flow again for the rest of the world. If you created an effect with a duration that extends beyond the time stop’s duration, such as wall of fire, it immediately affects others again, but it doesn’t have any of the effects that happen only when you first cast the spell." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68f447eb-056f-4ea4-95ba-4ae1652f963f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
