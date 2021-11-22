using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Synesthesia : Template
    {
        public static readonly Guid ID = Guid.Parse("c2da85e4-3cdb-4f3c-8ad9-dc19db1341d6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Synesthesia",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ea9d9b8-8527-4510-8c0e-7bcd8f780ed7"), Type = TextBlockType.Text, Text = "The target's senses are suddenly rewired in unexpected ways, causing them to process noises as bursts of color, smells as sounds, and so on. This has three effects, and the target must attempt a Will save." };
            yield return new TextBlock { Id = Guid.Parse("7326260c-2f75-485e-a481-806208e86856"), Type = TextBlockType.Enumeration, Text = "Due to the distraction, the target must succeed at a DC 5 flat check each time it uses a concentrate action, or the action fails and is wasted." };
            yield return new TextBlock { Id = Guid.Parse("4132f993-15c9-46a8-990a-d258f6e23986"), Type = TextBlockType.Enumeration, Text = "The target's difficulty processing visual input makes all creatures and objects concealed from it." };
            yield return new TextBlock { Id = Guid.Parse("85832a0e-4d20-48ac-9b98-9baee0063141"), Type = TextBlockType.Enumeration, Text = "The creature has trouble moving, making it clumsy 3 and giving it a –10-foot status penalty to its Speeds." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ab38ffe3-52d7-4a7d-a4c8-f30c7aeaccd7"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ae08dad4-05f4-4707-a67b-d40aa77b6035"), Type = TextBlockType.Text, Text = "You can target up to five creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d8181a73-2e35-4039-92af-28c813e3a74e"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is affected for 1 round.",
                Failure = "The target is affected for 1 minute.",
                CriticalFailure = "As failure, and the target is stunned 2 as it attempts to process the sensory shifts."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e2c38de-59d7-41ff-a468-527756ee70ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
