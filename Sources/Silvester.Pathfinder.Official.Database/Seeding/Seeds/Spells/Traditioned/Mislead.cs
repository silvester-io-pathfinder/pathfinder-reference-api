using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Mislead : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mislead",
                Level = 6,
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You turn yourself invisible and create an illusory duplicate of yourself. When you Sustain the Spell, you can mentally dictate a course of action for your duplicate to follow that round. Your duplicate acts as though it had your full number of actions, though it can’t actually affect anything in the environment. Both the duplicate and your invisibility persist for the spell’s duration. Performing a hostile action doesn’t end mislead’s invisibility, just like a 4th-level invisibility spell. A creature that determines the duplicate is an illusion doesn’t necessarily know you’re invisible, and one that can see your invisible form doesn’t necessarily know your duplicate is an illusion." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you Cast a Spell, attack, or otherwise interact with another creature, as a part of that action you can attempt a Deception check against observers’ Perception DCs to convince them your duplicate used that action. This doesn’t fool anyone who’s aware your duplicate is an illusion, nor does it work if the attack obviously couldn’t have come from the duplicate. For instance, if you fired a ray, you could make it look like it came from the duplicate as long as the duplicate was positioned appropriately, but if you attacked with a sword and your duplicate was across the room from the target, your Deception check would automatically fail." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
