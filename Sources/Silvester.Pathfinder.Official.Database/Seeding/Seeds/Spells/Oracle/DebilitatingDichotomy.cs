using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DebilitatingDichotomy : Template
    {
        public static readonly Guid ID = Guid.Parse("39c1e512-ad76-4e16-a2ed-3d9c6f437b3d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Debilitating Dichotomy",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature other than you.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6104694-07f5-4cb4-9727-e109e1c51b1f"), Type = TextBlockType.Text, Text = "You reveal a glimpse of the impossible conflicts between the divine anathema behind your curse, forcing you to reckon with another’s conflicts as well. You and the target each take 9d6 mental damage with a basic Will save, and the target is stunned 1 if it critically fails its save. You get a degree of success one better than you rolled for your saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("85271525-a672-4ce0-808f-40618d7fabb7"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2d4d9571-4003-4e6c-8251-07471568ed6a"), Type = TextBlockType.Text, Text = "The damage increases by 3d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5919d65-998a-49fc-ad35-0a44c18ffd39"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 231
            };
        }
    }
}
