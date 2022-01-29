using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WinningStreak : Template
    {
        public static readonly Guid ID = Guid.Parse("3da94db1-eb3f-404a-b235-17b8bd90277f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Winning Streak",
                Level = 4,
                Range = "20 feet.",
                Duration = "1 round (see text).",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79aea4c6-d208-407a-b3a3-e130256cacac"), Type = TextBlockType.Text, Text = "The target is energized by its good fortune as it spreads to others'as long as they keep winning. It gains the quickened condition for 1 round. If the target or one of their allies within 20 feet gets a critical success on an attack roll against a significant foe, whoever got the critical success becomes quickened if they weren't already, and the duration of the winning streak is extended by another round. Creatures quickened by the spell can use the extra action to Strike, Step, or Stride. If a full round passes without the target or one their allies critically succeeding on an attack roll against a significant foe, the winning streak breaks and the spell ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2430d1eb-aa47-42c5-8021-0dbeb01a2abb"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bf194ea-9cd7-4c14-b463-5baebf709c3d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 141
            };
        }
    }
}
