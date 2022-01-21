
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ZealForBattle : Template
    {
        public static readonly Guid ID = Guid.Parse("c8ee2806-085a-4c67-8f9d-930cd091180b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Zeal For Battle",
                Level = 4,
                Trigger = "You and at least 1 ally are about to roll initiative.",
                Range = "10 feet.",
                Targets = "You and the triggering ally.",
                DomainId = Domains.Instances.Zeal.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76af82dc-6434-44f6-851c-77e3585b11fe"), Type = TextBlockType.Text, Text = "You stoke the righteous anger within yourself and an ally. You and the target ally each roll a d20 and use the higher result for both your initiative rolls. You each still use your own Perception modifier or other statistic to determine your results." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a540e06c-fac3-45b7-899d-24da6a534c17"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ae91e439-936d-467c-b83c-55bbedef4660"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("55cc7394-fa22-41eb-a4ab-ec3ab868a2ec"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("5a0ede9e-001c-4688-9425-52edffbbb254"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("0b0df53e-03da-4667-a4be-bb22bd293c21"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("d29e2795-f8f1-4bb4-bbb6-0e42b798d246"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e944198-c591-48ad-98ad-8f3a03f5b6d1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
