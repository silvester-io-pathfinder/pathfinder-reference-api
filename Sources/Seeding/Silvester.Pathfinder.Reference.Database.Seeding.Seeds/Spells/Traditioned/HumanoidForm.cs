using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HumanoidForm : Template
    {
        public static readonly Guid ID = Guid.Parse("8566d394-5233-444e-ad39-4a8beb9a7f53");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Humanoid Form",
                Level = 2,
                IsDismissable = true,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d98e32e-c316-4339-b3c8-da732e8248c0"), Type = TextBlockType.Text, Text = "You transform your appearance to that of a Small or Medium humanoid, such as a dwarf, elf, goblin, halfling, human, orc, or lizardfolk. You gain the humanoid trait in addition to your other traits while in this form, as well as any trait related to the creature's kind (such as goblin or human). If this transformation reduces your size, it reduces your reach accordingly (as the shrink spell). This transformation doesn't change your statistics in any way, and you don't gain any special abilities of the humanoid form you assume. You can still wear and use your gear, which changes size (if necessary) to match your new form. If items leave your person, they return to their usual size." };
            yield return new TextBlock { Id = Guid.Parse("81664c45-eb8d-4dcc-b87f-dd54016bf758"), Type = TextBlockType.Text, Text = "Humanoid form grants you a +4 status bonus to Deception checks to pass as a generic member of the chosen ancestry, and you add your level even if you're untrained, but you can't make yourself look like a specific person. If you want to Impersonate an individual, you still need to create a disguise, though the GM won't factor in the difference in ancestry when determining the DC of your Deception check. You can Dismiss this spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c103e51f-7098-419e-80ae-d0ce3a89e7a5"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ab95e947-7736-430a-80bd-7d0a2dc55bb8"), Type = TextBlockType.Text, Text = "You gain darkvision or low-light vision if the form you assume has that ability." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("dbfae4ee-2e5e-4413-a4a1-b5c9aed0d8ca"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5e28c471-3245-43ae-b39f-3b4f11d853b1"), Type = TextBlockType.Text, Text = "You can take on the appearance of a Large humanoid. If this increases your size, you gain the effects of the enlarge spell." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a1df7a7c-3505-47b4-ac6d-e53449821a46"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("7be90a73-c2d0-4ff1-88d3-a29272fb6d8b"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("222ba300-8e8e-452a-8c98-89e1c6e72b16"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
