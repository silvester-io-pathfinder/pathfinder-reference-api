using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class InterstellarVoid : Template
    {
        public static readonly Guid ID = Guid.Parse("4e39b70b-f8b5-49b8-a73f-6b8c5e06a64b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Interstellar Void",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d43ae96b-8e79-428f-ab6c-8748347092d1"), Type = TextBlockType.Text, Text = "You call upon the frigid depths of outer space to bring a terrible chill to your enemy. The target is cloaked in the freezing void, which deals 3d6 cold damage immediately and when you Sustain the Spell on future turns, with a basic Fortitude save. The target is fatigued for as long as the effect persists." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("07846b9d-3c58-4785-bde2-532b07c398f5"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("17791204-050f-44d2-9827-dc643957d0b7"), Type = TextBlockType.Text, Text = "The cold damage increases by 1d6." }
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
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a69f67c2-76ea-4c24-a5bf-679d8278bbc5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
