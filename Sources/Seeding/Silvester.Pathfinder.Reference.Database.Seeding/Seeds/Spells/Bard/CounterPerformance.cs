using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CounterPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("b6aa72a7-3729-4c21-9047-b4e50f8b16a7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Counter Performance",
                Level = 1,
                Area = "60-foot emanation.",
                Trigger = "You or an ally within 60 feet rolls a saving throw against an auditory or visual effect.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1705a317-25fc-4364-abb6-50fd83cb393c"), Type = TextBlockType.Text, Text = "Your performance protects you and your allies. Roll a Performance check for a type you know: an auditory performance if the trigger was auditory, or a visual one for a visual trigger. You and allies in the area can use the better result between your Performance check and the saving throw." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fortune.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8215602-216d-46f6-89ac-c2e7a3e81cb3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
