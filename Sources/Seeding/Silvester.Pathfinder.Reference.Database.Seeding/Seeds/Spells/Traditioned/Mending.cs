using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Mending : Template
    {
        public static readonly Guid ID = Guid.Parse("ea92b250-fc6d-43d9-aee0-f1fbb92111ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mending",
                Level = 1,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Targets = "Non-magical object of light Bulk or less.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9427d1d8-f2a9-4479-b2d1-df79e114d8e1"), Type = TextBlockType.Text, Text = "You repair the target item. You restore 5 Hit Points per spell level to the target, potentially removing the broken condition if this repairs it past the item’s Broken Threshold. You can’t replace lost pieces or repair an object that’s been completely destroyed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f413d25e-2a77-4a5e-ba7c-31e2518d7115"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0dbc66ad-aa3e-4c94-a4b7-b0fc21590de2"), Type = TextBlockType.Text, Text = "You can target a non-magical object of 1 Bulk or less." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b7c35473-2d5c-46be-870d-151e188f4215"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d5b06cf9-a535-4979-895d-a6850b8bea0f"), Type = TextBlockType.Text, Text = "You can target a non-magical object of 2 Bulk or less, or a magical object of 1 Bulk or less." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04113205-0abb-4acd-9142-690ca27467ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
