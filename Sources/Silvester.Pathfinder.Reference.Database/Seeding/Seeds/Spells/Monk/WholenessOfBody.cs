using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
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
