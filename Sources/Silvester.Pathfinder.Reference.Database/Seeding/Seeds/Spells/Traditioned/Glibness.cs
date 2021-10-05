using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Glibness : Template
    {
        public static readonly Guid ID = Guid.Parse("eb0b0979-ee50-4a1a-af2c-8baeb58f06dd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glibness",
                Level = 4,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6a559e6-ea69-4847-8e66-76ca556036dd"), Type = TextBlockType.Text, Text = "Falsehoods pass your lips as smoothly as silk. You gain a +4 status bonus to Deception checks to Lie and against Perception checks to discern if you are telling the truth, and you add your level even if you’re untrained. If the implausibility of your lies prompts a circumstance penalty or a DC increase, reduce that penalty or increase by half." };
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d489e35-b51c-4946-8889-b5949c0dfb45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
