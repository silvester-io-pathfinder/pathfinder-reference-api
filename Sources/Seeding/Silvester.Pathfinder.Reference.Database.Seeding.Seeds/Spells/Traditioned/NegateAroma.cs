using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NegateAroma : Template
    {
        public static readonly Guid ID = Guid.Parse("32c8a05d-6244-4e13-8a1b-1b74de2970d6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Negate Aroma",
                Level = 1,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a708c7e-f042-444d-94e7-cb78ba8794b5"), Type = TextBlockType.Text, Text = "The target loses its odor, preventing creatures from passively noticing its presence via smell alone, even if the creatures have precise or imprecise scent. A creature attempting a Perception check to Seek with scent and other senses might notice the lack of natural scent. If the target has any abilities that result from its smell, such as an overpowering scent, those abilities are also negated." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ed006011-6a90-4c1f-a001-aa0d0ebb565a"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b133faa0-9371-4c53-a44c-ca03bf4866b3"), Type = TextBlockType.Text, Text = "The range increases to 30 feet, and you can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6edb8f45-5d76-4cd4-b2ef-820f274428e7"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f82ced57-bbf0-4e05-9719-ad2324b028df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 354
            };
        }
    }
}
