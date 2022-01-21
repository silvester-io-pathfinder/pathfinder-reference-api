using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InspireCourage : Template
    {
        public static readonly Guid ID = Guid.Parse("7bdedbc0-e87c-4649-979b-1f9be7fc80ff");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inspire Courage",
                Level = 1,
                Area = "60-foot emenation.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05c4e965-ff79-4e53-ae15-c61335228100"), Type = TextBlockType.Text, Text = "You inspire yourself and your allies with words or tunes of encouragement. You and all allies in the area gain a +1 status bonus to attack rolls, damage rolls, and saves against fear effects." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2e2f0739-de0d-4837-a6ab-d3ac03647ef6"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4e92d06d-1814-4785-9003-776646c7f51b"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("4dc535c2-d8bc-45e2-aac4-57d3fc4cbea0"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("3222d514-e7ed-4504-a3b3-b7ba85a67757"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("30373b7f-2963-4afd-9eb4-ead37590b6e8"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("7790deb1-5c49-4713-9ee4-45fe2b513586"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("1a7bef5d-2578-4604-9f3b-322a5c73321b"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca86b271-50a6-4095-833a-dd5bac5e4c4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
