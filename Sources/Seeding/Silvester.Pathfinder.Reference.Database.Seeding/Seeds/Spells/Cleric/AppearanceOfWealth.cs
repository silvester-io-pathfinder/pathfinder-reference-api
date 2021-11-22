using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AppearanceOfWealth : Template
    {
        public static readonly Guid ID = Guid.Parse("87972b11-0738-4bfe-8ce2-54a9a1353e43");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Appearance of Wealth",
                Level = 1,
                Range = "30 feet.",
                Area = "5-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Wealth.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28e5b8d0-21c9-46f1-b346-1f5a70a64dae"), Type = TextBlockType.Text, Text = "You create a brief vision of immense wealth filling the spell's area. Each creature within 20 feet of the area that could be enticed by material wealth must attempt a Will saving throw. A creature that enters the area automatically disbelieves the illusion, and disbelieving the illusion ends any fascinated condition imposed by the spell. As long as you Sustain the Spell, other creatures react to the treasure like they would any other illusion, but they are not at risk of becoming fascinated." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c39c3f55-551d-4c8f-b87d-a30e4cb10ff0"),
                CriticalSuccess = "The creature disbelieves the illusion and is unaffected by it.",
                Success = "The creature is fascinated by the wealth until it has completed its first action on its next turn.",
                Failure = "The creature is fascinated by the illusion.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f0c2370-5423-4f7f-aac2-4567c547f364"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
