using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DreadAura : Template
    {
        public static readonly Guid ID = Guid.Parse("4858f60e-9239-44b6-ac28-6b8856fc9679");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dread Aura",
                Level = 4,
                Area = "30-foot-radius emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4858f60e-9239-44b6-ac28-6b8856fc9679"), Type = TextBlockType.Text, Text = "You emit an aura of terror. Foes in the area are frightened 1 and unable to reduce the condition." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4858f60e-9239-44b6-ac28-6b8856fc9679"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
