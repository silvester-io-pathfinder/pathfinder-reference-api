using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CommandingLash : Template
    {
        public static readonly Guid ID = Guid.Parse("181e6ff7-3975-474a-afc8-0134b64eb336");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Commanding Lash",
                Level = 4,
                Requirements = "Your most recent action dealt damage to a target.",
                Range = "100 feet.",
                Duration = "Until the end of the target's next turn.",
                Targets = "A creature you dealt damage to on your most recent action.",
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
            yield return new TextBlock { Id = Guid.Parse("91d21191-eee1-4700-b812-b716e84c5126"), Type = TextBlockType.Text, Text = "With the threat of more pain, you compel a creature you've recently harmed. You issue a command to the target, with the effects of the spell command." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("68bb8ace-cfcc-43ea-993c-5821d2ea9d78"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("53bc7fda-787a-4086-a433-54c77323e042"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("803c5616-6798-4b43-8cf5-5b20d7356eb3"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("df6c4a02-fd78-4a7d-b8cc-e68c3d4d9111"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("ecaee483-114b-40aa-8fa9-e16e2fa8004b"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54a55670-1944-44dc-b003-b7a4b52eb082"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
