using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VeilOfConfidence : Template
    {
        public static readonly Guid ID = Guid.Parse("5aa20247-696a-40c0-89ff-6b9de4da1a5b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Veil of Confidence",
                Level = 1,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Confidence.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1df2451-4a4b-4ef7-abf8-fdadd8e8aa30"), Type = TextBlockType.Text, Text = "You surround yourself in a veil of confidence. You reduce your current frightened condition by 1, and whenever you would become frightened during the duration, reduce the amount by 1." };
            yield return new TextBlock { Id = Guid.Parse("19f41470-69c9-4f57-bdad-4b49ea367da2"), Type = TextBlockType.Text, Text = "If you critically fail a save against fear, veil of confidence ends immediately, and you increase any frightened condition you gain from the critical failure by 1 instead of decreasing it." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a96a5fd3-4ce1-4cf8-a9ac-d12037ab6a30"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ce8b8ed5-a4e6-4c0f-89aa-36aaf11ff3f0"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("c5d7bc51-ddcf-4241-af17-f1c0cd71ba2e"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("fb900808-1cd1-4ddb-8bc7-4cb9ad7cc7eb"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("505371fb-09d0-480a-a553-fa986bef1378"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
