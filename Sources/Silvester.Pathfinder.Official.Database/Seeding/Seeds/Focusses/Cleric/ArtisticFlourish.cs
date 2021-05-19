using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Cleric.Instances
{
    public class ArtisticFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Artistic Flourish",
                Level = 4,
                Range = "15 feet.",
                Duration = "10 minutes.",
                Targets = "1 item or work of art that fits entirely within the range.",
                DomainId = Domains.Instances.Creation.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You transform the target to make it match your artisanal and artistic vision. If you have expert proficiency in Crafting, the item grants a +1 item bonus to attack rolls if it’s a weapon or skill checks if it’s a skill tool. The target is a beautiful and impressive piece for its new quality, but the effect is obviously temporary, so its monetary value doesn’t change." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you cast this spell, any previous artistic flourish you had cast ends." };
        }

        public override IEnumerable<FocusHeightening> GetHeightenings()
        {
            yield return new FocusHeightening
            {
                Id = Guid.Parse(""),
                Level = "+7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have master proficiency in Crafting, the item grants a +2 item bonus instead." }
                }
            };

            yield return new FocusHeightening
            {
                Id = Guid.Parse(""),
                Level = "+10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Crafting, the item grants a +3 item bonus instead." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
