using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FingerOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("cdc2f5a9-7700-4eb0-9666-2db04f3cdbdf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Finger of Death",
                Level = 7,
                Range = "30 feet.",
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
            yield return new TextBlock { Id = Guid.Parse("d79044a2-4629-4714-8548-42eccb8dd5b6"), Type = TextBlockType.Text, Text = "You point your finger toward the target and speak a word of slaying. You deal 70 negative damage to the target. If the damage from finger of death reduces the target to 0 Hit Points, the target dies instantly." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cf89a994-5789-4383-bf9c-edd238600c63"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b62b3618-5959-4b00-8ebd-18347b6fd095"), Type = TextBlockType.Text, Text = "The damage increases by 10." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cf34df8-6934-4ead-a505-eb68db31f1d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
