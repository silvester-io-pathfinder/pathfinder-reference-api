using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OutcastsCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("4462f1ea-ffe2-4087-b1c2-7d3a56afbb3e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Outcast's Curse",
                Level = 4,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c031f36b-0a46-44d2-8f4c-2d863b8c3842"), Type = TextBlockType.Text, Text = "You afflict the target with a curse that makes its presence abrasive and off-putting. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f4173fcb-2339-4f3b-9a54-ef7ec5ef089e"),
                CriticalSuccess = "The target is unaffected.",
                Success = "For 10 minutes, the target must roll twice and use the worse result whenever attempting a Deception, Diplomacy, Intimidation, or Performance check, and creatures they encounter have an initial attitude toward them of one step worse (for instance, unfriendly instead of indifferent).",
                Failure = "As success, but the effect is permanent.",
                CriticalFailure = "As failure, and creatures that the target encounters have an initial attitude toward them of two steps worse."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e9aad343-324e-4568-9981-ba4a408792d8"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("fdd14de9-f886-4e29-93fa-d903e8c80f47"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("73159812-8479-4222-8422-ae07a5482ec9"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("0228bd68-b9e9-42dd-86ef-7ceab4894846"), Traits.Instances.Misfortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05562438-9a46-470a-bd80-4d1a05092715"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 355
            };
        }
    }
}
