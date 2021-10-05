using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AgileFeet : Template
    {
        public static readonly Guid ID = Guid.Parse("d7c54b2d-8134-4394-ba84-9a8200e3a906");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Agile Feet",
                Level = 1,
                Duration = "Until the end of your current turn.",
                DomainId = Domains.Instances.Travel.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f7fba5f-96f8-4c39-8243-9173143deb9c"), Type = TextBlockType.Text, Text = "The blessings of your god make your feet faster and your movements more fluid. You gain a +5-foot status bonus to your Speed and ignore difficult terrain. As part of casting agile feet, you can Stride or Step; you can instead Burrow, Climb, Fly, or Swim if you have the appropriate Speed." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3319e87b-4ce1-42f7-b152-66087bb93f0b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
