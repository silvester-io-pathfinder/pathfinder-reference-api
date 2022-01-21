using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DirgeOfDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("ad3f682d-cc88-4e3d-9de7-c25acecb7a9d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dirge of Doom",
                Level = 3,
                Area = "30-foot emenation.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e23b600-2f70-4950-a46a-68dfc418c0c1"), Type = TextBlockType.Text, Text = "Foes within the area are frightened 1. They can't reduce their frightened value below 1 while they remain in the area." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9764fe51-8860-4f89-8155-d59d34a7856c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("91aa2075-2299-492d-bdd3-2d1e687fdb22"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("bbf3551d-697d-4d93-9e11-e7ed60790d35"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("845606fe-0075-4856-b7fd-2526c8c1f900"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("36d44343-9f72-4b4a-a402-219c2dc74d8f"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("14ec6b9d-68fd-4590-866d-f1ed07f8288c"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ba439360-6083-4fac-9716-afead0c8d979"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("0e310d1d-95b0-4bbd-897a-7d6263b50c85"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb2d7eaa-da10-4669-81bb-2eb54b631c9d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
