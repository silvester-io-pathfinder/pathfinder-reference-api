using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowsWeb : Template
    {
        public static readonly Guid ID = Guid.Parse("0a2a8d57-780a-4221-9135-44163b82d0a3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow's Web",
                Level = 7,
                Area = "30-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59d58dcc-9da2-4c18-b825-6c8ea481298d"), Type = TextBlockType.Text, Text = "Grasping darkness surges from you, dealing 14d4 negative damage. Each creature in the area must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("44a8a6b2-6bd7-43f3-8252-a58e68a843d2"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b7545368-2e77-437c-ab5c-0d97249c945a"), Type = TextBlockType.Text, Text = "The negative damage increases by 2d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("35de6101-4e70-4304-ac09-f031d17edb34"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and is enfeebled 1 for 1 round.",
                Failure = "The creature takes full damage and is enfeebled 2 for 1 round.",
                CriticalFailure = "The creature takes double damage and is stunned 1, enfeebled 2 for 1 round, and immobilized for 1 round or until it Escapes, whichever comes first."
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Monk.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79c1552e-6fef-4274-b59d-2d12b6fedad6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
