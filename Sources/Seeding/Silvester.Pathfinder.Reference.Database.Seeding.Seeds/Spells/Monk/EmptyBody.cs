using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EmptyBody : Template
    {
        public static readonly Guid ID = Guid.Parse("2848c34e-d587-452e-a123-c10dae2674d7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Empty Body",
                Level = 9,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("065d97d9-9db4-4b7a-9c06-34704fe09c8c"), Type = TextBlockType.Text, Text = "You turn ethereal, with the effects of ethereal jaunt, but you don't need to concentrate." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0142e8de-1ee8-4541-9589-0f77a7ce8b8d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("550bc38c-5c00-464f-9cc4-60b5b93c0e43"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8e4047df-4983-4d02-b4b0-7ac14fcf7897"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("c9cc03d1-0b6a-46c1-a421-0e6056f365e2"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62cece88-7c54-41b1-9035-8a111ec9ec85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
