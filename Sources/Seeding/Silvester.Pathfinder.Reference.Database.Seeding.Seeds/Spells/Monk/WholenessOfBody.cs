using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WholenessOfBody : Template
    {
        public static readonly Guid ID = Guid.Parse("d734caad-4618-439d-a6ca-21522f5f82f4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wholeness of Body",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a870683d-8597-4e03-ba8d-aa288bd01b45"), Type = TextBlockType.Text, Text = "You heal yourself in one of the following ways, chosen by you when you cast the spell." };
            yield return new TextBlock { Id = Guid.Parse("f618cddd-fb56-49b5-95b5-3a44e35ac9ff"), Type = TextBlockType.Enumeration, Text = "You regain 8 Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("0b89d019-c404-4e85-8f24-775f9b611ad7"), Type = TextBlockType.Enumeration, Text = "You attempt to cure one poison or disease afflicting you; attempt to counteract the affliction." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3a499db3-6fd1-4cf8-aa21-0b78c08e7b65"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c342ace1-2628-4a72-af0c-98c5446d0283"), Type = TextBlockType.Text, Text = "If you choose to regain Hit Points, the Hit Points regained increase by 8." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a1e7e1e2-3a53-4d87-93a0-eb43566d0b08"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d4a40ed1-c911-49da-bd1f-48adf7d5224e"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("247236fe-62be-4810-ad87-3e5ac9a7df15"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("e1dfacd0-45c3-4391-8f1c-aa6a0ce9a5ea"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("9f4e891a-e938-437c-a061-befd3fe20f41"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af17d126-f207-4cac-a23f-983b06e9345b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
