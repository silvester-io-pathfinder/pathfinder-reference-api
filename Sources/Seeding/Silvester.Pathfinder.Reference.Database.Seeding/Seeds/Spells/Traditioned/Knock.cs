using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Knock : Template
    {
        public static readonly Guid ID = Guid.Parse("d4b189b3-2307-4092-8e64-dcdfbe6ee5e7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Knock",
                Level = 2,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 door, lock, or container.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a938e2d-48bc-4330-977c-d91e89b75f5f"), Type = TextBlockType.Text, Text = "You make the target easier to open. Knock grants a +4 status bonus to any creature that tries to open the target door, lock, or container with an Athletics or a Thievery check. You can attempt a Thievery check to open the target as part of casting knock, and you add your level even if you're untrained." };
            yield return new TextBlock { Id = Guid.Parse("59a6a59e-7f5a-4274-86e8-0e1b5f4f270e"), Type = TextBlockType.Text, Text = "Knock counteracts lock." };
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
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e2dd6f5-686b-455a-874f-ed1a3010c64d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
