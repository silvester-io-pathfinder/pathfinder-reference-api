using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ItemFacade : Template
    {
        public static readonly Guid ID = Guid.Parse("0711d92f-7807-4e29-86d7-713215d6c9e4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Item Facade",
                Level = 1,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 object no more than 10 feet by 10 feet by 10 feet.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c3b8e98-a33b-440b-8b62-6545d6d4d943"), Type = TextBlockType.Text, Text = "You make the target object look and feel as though it were in much better or worse physical condition. When you cast this spell, decide whether you want to make the object look decrepit or perfect. An item made to look decrepit appears broken and shoddy. An intact item made to look better appears as though it's brand new and highly polished or well maintained. A broken item appears to be intact and functional. Destroyed items can't be affected by this spell. A creature that Interacts with the item can attempt to disbelieve the illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4a0f9fe7-6530-47db-b346-c1703cde2b5c"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4f575444-d996-4b10-a510-066674a1b5d6"), Type = TextBlockType.Text, Text = "The duration is 24 hours." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb920945-572d-4fa7-886f-77b2e2bf353b"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("912f91ea-80ec-4dc5-bb71-473bcbd161f3"), Type = TextBlockType.Text, Text = "The duration is unlimited." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1509f3ad-e669-419c-8263-bf29527a2af5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
