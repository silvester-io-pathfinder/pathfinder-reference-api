using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Bane : Template
    {
        public static readonly Guid ID = Guid.Parse("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bane",
                Level = 1,
                Area = "5-foot emanation.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b9d980a-4147-43bd-a3b7-90935943b1fe"), Type = Utilities.Text.TextBlockType.Text, Text = "You fill the minds of your enemies with doubt. Enemies in the area must succeed at a Will save or take a –1 status penalty to attack rolls as long as they are in the area. Once per turn, starting the turn after you cast bane, you can use a single action, which has the concentrate trait, to increase the emanation's radius by 5 feet and force enemies in the area that weren't yet affected to attempt another saving throw. Bane can counteract bless." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8f087fff-b48f-4453-a42c-fb27bade8e48"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b777946e-43dc-4e56-ac2d-17b628d2466b"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06838ab3-c2eb-413d-94a9-8186496f7aa6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 320
            };
        }
    }
}
