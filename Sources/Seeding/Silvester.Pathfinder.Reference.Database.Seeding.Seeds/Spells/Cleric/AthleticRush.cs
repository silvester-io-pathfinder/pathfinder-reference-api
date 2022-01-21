using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AthleticRush : Template
    {
        public static readonly Guid ID = Guid.Parse("c64c83c7-6c0d-4321-a93a-bfb597bed961");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Athletic Rush",
                Level = 1,
                Duration = "1 round.",
                DomainId = Domains.Instances.Might.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14df23ce-9c2f-4acd-860e-31c1edf92de8"), Type = TextBlockType.Text, Text = "Your body fills with physical power and skill. You gain a +10- foot status bonus to Speed and a +2 status bonus to Athletics checks. As a part of Casting this Spell, you can use a Stride, Leap, Climb, or Swim action. The spell's bonuses apply during that action." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c968cda4-049a-4b56-8d82-d7ebbd2b7dab"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("19d48185-c7fd-4c25-a7e0-52f6d6147177"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("52405b7a-bb09-4021-9910-34f1ad6cf3b2"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48d440d7-b842-4fb0-9302-ed4f29b806e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
