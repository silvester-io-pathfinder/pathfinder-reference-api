using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HuntersVision : Template
    {
        public static readonly Guid ID = Guid.Parse("e186ebc1-8e33-4b62-a0cf-f0ceddee726a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hunter's Vision",
                Level = 5,
                Targets = "1 hunted prey.",
                Range = "30 feet.",
                Duration = "10 minutes.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60c7c9ae-9867-4419-9c3b-1fe678d0a0a3"), Type = TextBlockType.Text, Text = "Your target glows with a magical aura visible only to you and those who follow your lead. Your target is visible to you and others sharing your Hunt Prey benefits even if it wouldn't normally be due to lighting or the concealed or invisible conditions, though cover from opaque objects still blocks your sight. You ignore the flat check against the target due to the concealed condition, and the target isn't automatically hidden from you due to darkness or being invisible." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ec31b9c1-be1b-4acc-a635-979393801aba"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9193989c-6c0d-42bb-ac69-0324aa85d38d"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("fe3ba742-328b-4186-8da0-c4d6579d947f"), Traits.Instances.Ranger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2140ebd-a661-4d0a-a762-dfeddfe33412"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}