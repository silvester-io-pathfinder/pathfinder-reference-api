using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FaerieDust : Template
    {
        public static readonly Guid ID = Guid.Parse("f7bb400c-ad59-4d72-8623-0de050005121");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Faerie Dust",
                Level = 1,
                Range = "30 feet.",
                Area = "5-foot burst or more.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eeaf4af4-f117-41b9-b492-a48951c8508a"), Type = TextBlockType.Text, Text = "You sprinkle magical dust in the spell's area, making those within easier to trick. Each creature in the area must attempt a Will save. For each additional action you use Casting the Spell, the burst's radius increases by 5 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("286de267-2f52-4d2e-8987-a2c88bef5364"),
                Level = "+3",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8af39bcf-961f-47c2-b055-71b6c64291f8"), Type = TextBlockType.Text, Text = "The initial radius increases by 5 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e891f741-047b-440d-a5eb-78887054d97b"),
                Success = "The creature is unaffected.",
                Failure = "The creature can't use reactions and takes a –2 status penalty to Perception checks and Will saves.",
                CriticalFailure = "As failure, and the creature also takes a –1 status penalty to Perception checks and Will saves for 1 minute."
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a841ceca-b4a5-4b26-9a82-84e54637893c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
