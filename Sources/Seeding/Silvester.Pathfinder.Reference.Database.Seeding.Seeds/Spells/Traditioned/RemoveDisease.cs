using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RemoveDisease : Template
    {
        public static readonly Guid ID = Guid.Parse("be19cf0a-bdde-4460-9753-ac2b7baf0f04");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Remove Disease",
                Level = 3,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee5be692-8ab3-4ab7-b7b6-d810796a6af1"), Type = TextBlockType.Text, Text = "Healing magic purges disease from a creature's body. You attempt to counteract one disease afflicting the target." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2f6c179f-0253-42c6-a9fc-aac7e1bb79e7"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("28e36d25-2136-41f1-840a-27b9294247cd"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cf4b834-01f4-47e1-b02a-0feeebb81942"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
