using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChampionsSacrifice : Template
    {
        public static readonly Guid ID = Guid.Parse("c089cb28-19b1-4e86-a2fd-42a4182fe91f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Champion's Sacrifice",
                Level = 6,
                Trigger = "An ally is hit by a Strike, or an ally fails a saving throw against an effect that doesn't affect you.",
                Range = "30 feet.",
                Targets = "1 ally.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("574f56ad-0fb6-490a-8e0d-4d9cc392dbbe"), Type = TextBlockType.Text, Text = "You form a link with an ally, allowing you to take harm in their stead. All the effects of the hit or failed save are applied to you instead of the ally. For example, if the target critically fails a saving throw against a fireball, you would take double damage. These effects ignore any resistances, immunities, or other abilities you have that might mitigate them in any way, although those of the target apply before you take the effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1862b03a-63ba-45fe-87ab-5c9943f0d237"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("fce26b9a-dd43-4119-857a-baa16ef7892b"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("3851b25b-8ac1-41b5-9019-f297f219c15d"), Traits.Instances.Champion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adef15a3-c311-43d1-8f17-033888b0360b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
