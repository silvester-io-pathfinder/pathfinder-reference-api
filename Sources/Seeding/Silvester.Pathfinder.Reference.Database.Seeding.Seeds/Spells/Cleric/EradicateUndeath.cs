using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EradicateUndeath : Template
    {
        public static readonly Guid ID = Guid.Parse("fd891d12-a7c1-4fc6-826e-0d862175d4fd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Eradicate Undeath",
                Level = 4,
                Area = "30-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Death.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db1dd925-57f7-408a-bb9a-6b73dda883a8"), Type = TextBlockType.Text, Text = "A massive deluge of life energy causes the undead to fall apart. Each undead creature in the area takes 4d12 positive damage." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e87e6037-efaf-4601-bc96-5907555628f3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8764acd3-4f15-49bb-9cef-63d70b35caca"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("02b131fb-964c-47ae-834b-467282172078"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("30321873-62c9-4cb8-ab58-b5dc9dd7b39b"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7df0c20f-195e-4953-9f03-0991caf3110a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 392
            };
        }
    }
}
