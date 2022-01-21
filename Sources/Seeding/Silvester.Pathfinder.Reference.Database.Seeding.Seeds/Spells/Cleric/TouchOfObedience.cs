using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TouchOfObedience : Template
    {
        public static readonly Guid ID = Guid.Parse("f8843f30-1ace-4783-8eab-1cd5c4ab752e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Touch of Obedience",
                Level = 1,
                Range = "Touch.",
                Duration = "Varies.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Tyranny.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("390eafe6-30d1-4930-8481-c17d06fa5f89"), Type = TextBlockType.Text, Text = "Your imperious touch erodes the target's willpower, making it easier to control. The target attempts a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e8883cb7-9d0f-48e3-a7d8-9223974c55eb"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stupefied 1 until the end of your current turn.",
                Failure = "The target is stupefied 1 until the end of your next turn.",
                CriticalFailure = "The target is stupefied 1 for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("57a5a3e4-349b-456c-9718-cfe455d3490e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0f59c19c-8f98-403e-9a1a-a5058d4fddf6"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("f83bb4d2-e6c0-4242-9fe5-3430b09f6478"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("88b9ff19-653d-4f94-bc2e-520ede55aa2f"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("207910d5-b461-46d7-889c-3e7542454192"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
