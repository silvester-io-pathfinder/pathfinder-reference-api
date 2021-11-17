using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WeaponSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("7b3b4fc4-1b9d-4cd2-9e8b-abdde2a036f0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Weapon Surge",
                Level = 1,
                Range = "Touch.",
                Targets = "1 weapon you're wielding.",
                DomainId = Domains.Instances.Zeal.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8ff9313-fbf3-4056-871d-c8e01401728c"), Type = TextBlockType.Text, Text = "Holding your weapon aloft, you fill it with divine energy. On your next Strike with that weapon before the start of your next turn, you gain a +1 status bonus to the attack roll and the weapon deals an additional die of damage. If the weapon has a striking rune, this instead increases the number of dice from the striking rune by 1 (to a maximum of 3 extra weapon dice)." };
            yield return new TextBlock { Id = Guid.Parse("5936895c-4b6c-4065-8aab-f9f2018201b5"), Type = TextBlockType.Text, Text = "If the target weapon leaves your possession, weapon surge immediately ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab9d38d4-cd25-40a7-ba4a-9681418528bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
