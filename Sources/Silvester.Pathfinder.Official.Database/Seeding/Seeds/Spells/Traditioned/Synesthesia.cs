using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Synesthesia : Template
    {
        public static readonly Guid ID = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741");

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
            yield return new TextBlock { Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), Type = TextBlockType.Text, Text = "The target’s senses are suddenly rewired in unexpected ways, causing them to process noises as bursts of color, smells as sounds, and so on. This has three effects, and the target must attempt a Will save." };
            yield return new TextBlock { Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), Type = TextBlockType.Enumeration, Text = "Due to the distraction, the target must succeed at a DC 5 flat check each time it uses a concentrate action, or the action fails and is wasted." };
            yield return new TextBlock { Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), Type = TextBlockType.Enumeration, Text = "The target’s difficulty processing visual input makes all creatures and objects concealed from it." };
            yield return new TextBlock { Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), Type = TextBlockType.Enumeration, Text = "The creature has trouble moving, making it clumsy 3 and giving it a –10-foot status penalty to its Speeds." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"), Type = TextBlockType.Text, Text = "You can target up to five creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"),
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
                Id = Guid.Parse("7cba3989-627e-45ef-8db0-94e22b25d741"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
