using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RemoveCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("cbbfa8a9-29f5-4f00-ab8d-a8091b26c82e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Remove Curse",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06d4cf6b-2a4f-47b4-a31a-a8f70e797fbe"), Type = TextBlockType.Text, Text = "Your touch grants a reprieve to a cursed creature. You attempt to counteract one curse afflicting the target. If the curse comes from a cursed item or other external source, a success indicates that the target creature can rid itself of the cursed item, but it doesn’t remove the curse from the item." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c090496-e762-43ce-9aea-f725a272ea4f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
