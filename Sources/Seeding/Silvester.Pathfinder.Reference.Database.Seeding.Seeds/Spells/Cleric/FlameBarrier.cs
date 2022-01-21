using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlameBarrier : Template
    {
        public static readonly Guid ID = Guid.Parse("d841d8d6-8dbe-42a4-bd92-d4533302ce1a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flame Barrier",
                Level = 4,
                Trigger = "An effect would deal fire damage to either you or an ally within range.",
                Range = "60 feet.",
                Targets = "The creature that would take fire damage.",
                DomainId = Domains.Instances.Fire.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4cfeee0-9d24-4ab7-8a34-a6971c265f40"), Type = TextBlockType.Text, Text = "You swiftly deflect incoming flames. The target gains fire resistance 15 against the triggering effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("812a3087-5e95-455c-84ce-eccf694adf54"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("882ec9ea-e90f-4683-b241-615c71b0934d"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("eeb8a0c4-892e-41c3-be7e-a41098d1f4d2"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d4a8e31b-7f88-42bd-8e33-71e278d4329f"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("1fc7416f-018f-49eb-bf31-0a84833414d0"), Traits.Instances.Cleric.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cf8bb1a-1953-4dd1-b741-802584223fa2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 392
            };
        }
    }
}
