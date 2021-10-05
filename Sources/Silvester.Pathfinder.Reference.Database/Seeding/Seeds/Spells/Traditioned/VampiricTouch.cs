using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VampiricTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("64be4389-bc36-4e72-a569-0eaf700fb16d");

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
            yield return new TextBlock { Id = Guid.Parse("e1a0c52b-5ec6-422a-a7e4-65efb924c388"), Type = TextBlockType.Text, Text = "Your touch leeches the lifeblood out of a target to empower yourself. You deal 6d6 negative damage to the target. You gain temporary Hit Points equal to half the negative damage the target takes (after applying resistances and the like). You lose any remaining temporary Hit Points after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ab8812c5-e6a4-4040-95ce-6bcb7d817c72"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("79364fb6-2341-4cfe-bfe3-f22471929d5f"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
                Id = Guid.Parse("0f009efd-28d5-40d7-b786-8ff46591437f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
