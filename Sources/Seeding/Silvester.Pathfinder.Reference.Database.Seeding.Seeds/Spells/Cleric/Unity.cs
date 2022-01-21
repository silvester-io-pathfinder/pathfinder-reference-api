using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Unity : Template
    {
        public static readonly Guid ID = Guid.Parse("891c75f8-0588-453f-a807-e0f1dde5a995");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unity",
                Level = 1,
                Trigger = "You and 1 or more allies within range are targeted by a spell or ability that allows a saving throw.",
                Range = "30 feet.",
                Targets = "Each ally targeted by the triggering spell.",
                DomainId = Domains.Instances.Family.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b81a409-7126-4d71-9341-c55d52603d16"), Type = TextBlockType.Text, Text = "You put up a united defense. Each ally can use your saving throw modifier instead of its own against the triggering spell. Each ally decides individually which modifier to use." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7c43fbbf-3c8e-44ed-ba98-ea435e67349a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("de6534a5-ff37-4eda-b8c0-d5651fff6c39"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("09ec21ed-ae89-47bc-8501-62c709326178"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("c4488fe9-e993-46dd-9203-442401efb99d"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e818b941-e875-4e81-8f76-907c69c8d765"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
