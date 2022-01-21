using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HurtlingStone : Template
    {
        public static readonly Guid ID = Guid.Parse("0808dc98-d5f9-4a23-b82e-7d7161418675");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hurtling Stone",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Earth.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93d8782b-10ea-4989-bf52-7bf9a92bde46"), Type = TextBlockType.Text, Text = "You evoke a magical stone and throw it, with your god's presence guiding your aim. Make a spell attack roll against the target. The stone deals bludgeoning damage equal to 1d6 plus your Strength modifier." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f7e55acf-3b53-4579-acb8-cc4d19c6a11d"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d0414da8-2be0-45b2-b532-bdf51005707b"), Type = TextBlockType.Text, Text = "The stone's damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("efbea13b-47b4-4857-a5c4-ffe92966f6ff"),
                CriticalSuccess = "The stone deals double damage.",
                Success = "The stone deals full damage.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("88c0b3aa-86aa-4b40-afc7-ce5889485e69"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0ccd15fe-bab1-4595-8a80-c4fb303ee64b"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("673b9d77-6bd1-4aa9-ae78-d7847f648c26"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("4f28a897-77d2-4284-9fa1-69fc7998082d"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("4527dae8-d18f-4715-b0eb-885c02bf2635"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("735cd8f2-3ee0-4172-bd5c-f890e8bc7de8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
