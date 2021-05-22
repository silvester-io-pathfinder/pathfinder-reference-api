
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fortune.ID;
            yield return Traits.Instances.Mental.ID;
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
