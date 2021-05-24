using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ZealousConviction : Template
    {
        public static readonly Guid ID = Guid.Parse("1a9f7c2c-03d9-487d-b4a2-1f64d4227e38");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Zealous Conviction",
                Level = 6,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "Up to 10 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65aa12a6-e8a1-44d5-b8db-290a3b15fd8f"), Type = TextBlockType.Text, Text = "You bypass your targets’ rational minds, instilling them with unshakable conviction and zeal. The targets each gain 12 temporary Hit Points and a +2 status bonus to Will saves against mental effects, as their faith overrides the signals from their own bodies and minds. If you tell a target to do something, it must comply with your request, though if it would normally find the task repugnant, it can attempt a Will save at the end of its turn each round due to the cognitive dissonance. On a success, it ends the spell’s effects on itself entirely." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f3e30eba-6c93-4f50-a8cb-c8f3addd819d"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("60bf8d36-e171-4c28-997a-f9a2eea7976d"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase to 18, and the status bonus to Will saves increases to +3." }
                }
            };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ae395bb-1f55-4393-a2f1-01d66fa2310e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
