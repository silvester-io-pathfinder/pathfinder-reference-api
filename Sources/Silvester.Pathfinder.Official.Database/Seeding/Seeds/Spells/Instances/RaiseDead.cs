using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RaiseDead : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Raise Dead",
                Level = 6,
                CastTime = "10 minutes",
                Cost = "Diamonds worth a total value of the target's level (minimum 1) x 200 gp.",
                Range = "10 feet.",
                Targets = "1 dead creature of 13th level or lower.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You attempt to call forth the dead creature’s soul, requiring the creature’s body to be present and relatively intact. The creature must have died within the past 3 days. If Pharasma has decided that the creature’s time has come (at the GM’s discretion), or if the creature doesn’t wish to return to life, this spell automatically fails, but the diamonds aren’t consumed in the casting." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If the spell is successful, the creature returns to life with 1 Hit Point, no spells prepared or spell slots available, no points in any pools or any other daily resources, and still with any long-term debilitations of the old body. The time spent in the Boneyard leaves the target temporarily debilitated, making it clumsy 2, drained 2, and enfeebled 2 for 1 week; these conditions can’t be removed or reduced by any means until the week has passed. The creature is also permanently changed by its time in the afterlife, such as a slight personality shift, a streak of white in the hair, or a strange new birthmark." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 15. The cost increases to the target’s level (minimum 1) × 400 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 17. The cost increases to the target’s level (minimum 1) × 800 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 19. The cost increases to the target’s level (minimum 1) × 1,600 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 21. The cost increases to the target’s level (minimum 1) × 3,200 gp." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
