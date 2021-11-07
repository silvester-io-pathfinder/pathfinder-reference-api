using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{

    public class PenumbralDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Penumbral Disguise",
                Level = 2,
                Range = "Touch.",
                Targets = "1 willing creature.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You wrap the target in shadows, granting them a +1 status bonus to Stealth checks to Hide while in dim light or darkness. In addition, the shadows mask the creature's features. While the creature is in dim light or darkness, other creatures must succeed at a Seek action against the spell's DC to discern details about the target's appearance. For example, without using Seek, other creatures can determine the target's general shape (such as humanoid), but they would need to Seek to determine the target's precise appearance or any other identifying information. Creatures with darkvision can still see the target and their features normally. The target's normal appearance is revealed in bright light." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The status bonus is +2. Creatures with darkvision can no longer discern details about the target while the target is in dim light or darkness without Seeking, though creatures with greater darkvision can still determine these details." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As 4th level, except the status bonus is +3 and creatures without darkvision can't determine even general details about the target while the target is in dim light or darkness unless they successfully Seek the target; these creatures see a vague shadow instead. Even on a successful Seek, they only determine general features, though they can see details on a critical success." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As 6th level, except the status bonus is +4 and even creatures with greater darkvision must Seek to discern details about the target while the target is in dim light or darkness." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Pathfinder172.ID,
                Page = 77
            };
        }
    }
}
