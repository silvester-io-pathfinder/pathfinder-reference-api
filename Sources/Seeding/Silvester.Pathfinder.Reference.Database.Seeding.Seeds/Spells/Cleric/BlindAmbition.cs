using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlindAmbition : Template
    {
        public static readonly Guid ID = Guid.Parse("a77e9671-1f54-4594-8b24-6dbfe6f9ddae");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blind Ambition",
                Level = 1,
                Range = "60 feet.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Ambition.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e6c12d7-bd68-4c3e-baeb-d0694991b992"), Type = TextBlockType.Text, Text = "You strengthen a target's ambition, increase its resentment of allies, and make its allegiances more susceptible to change. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("df20e7cc-c455-4c47-b308-208876fbf5ad"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a –1 status penalty to its saving throws and other defenses against attempts to Coerce it, Request something of it, or use mental effects to convince it to do something (such as a suggestion spell). This penalty applies only if the target is being encouraged to advance its own ambitions.",
                Failure = "As success, but the penalty is –2.",
                CriticalFailure = "The target is overcome with ambition, taking whatever actions would advance its own agenda over those of anyone else, even without attempts to convince it."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a86b67cc-bb13-4ba8-bf6d-0fcef1fcc6d0"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0caae6b4-2714-458f-b6f7-856c673a1b49"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("ef395eb7-d867-4d8f-8622-536c7c49d00f"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("bd5e8edd-8eae-4f01-82fc-07f0c978e53d"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("16e29cf9-475f-4409-8494-8cba091b94ed"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db7891ea-ce7f-40d4-be16-6fa5b5060f83"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
