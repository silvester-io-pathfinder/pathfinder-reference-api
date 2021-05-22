using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class VampiricTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("936734e8-1e4e-45f5-a62a-72f6e81cfd74");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vampiric Touch",
                Level = 3,
                Range = "Touch.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("936734e8-1e4e-45f5-a62a-72f6e81cfd74"), Type = TextBlockType.Text, Text = "Your touch leeches the lifeblood out of a target to empower yourself. You deal 6d6 negative damage to the target. You gain temporary Hit Points equal to half the negative damage the target takes (after applying resistances and the like). You lose any remaining temporary Hit Points after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("936734e8-1e4e-45f5-a62a-72f6e81cfd74"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("936734e8-1e4e-45f5-a62a-72f6e81cfd74"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("936734e8-1e4e-45f5-a62a-72f6e81cfd74"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
