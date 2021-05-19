using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class HumanoidForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Humanoid Form",
                Level = 2,
                IsDismissable = true,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You transform your appearance to that of a Small or Medium humanoid, such as a dwarf, elf, goblin, halfling, human, orc, or lizardfolk. You gain the humanoid trait in addition to your other traits while in this form, as well as any trait related to the creature’s kind (such as goblin or human). If this transformation reduces your size, it reduces your reach accordingly (as the shrink spell). This transformation doesn’t change your statistics in any way, and you don’t gain any special abilities of the humanoid form you assume. You can still wear and use your gear, which changes size (if necessary) to match your new form. If items leave your person, they return to their usual size." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Humanoid form grants you a +4 status bonus to Deception checks to pass as a generic member of the chosen ancestry, and you add your level even if you’re untrained, but you can’t make yourself look like a specific person. If you want to Impersonate an individual, you still need to create a disguise, though the GM won’t factor in the difference in ancestry when determining the DC of your Deception check. You can Dismiss this spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain darkvision or low-light vision if the form you assume has that ability." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can take on the appearance of a Large humanoid. If this increases your size, you gain the effects of the enlarge spell." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
