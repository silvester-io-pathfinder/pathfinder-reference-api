using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TimeBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("a726bf04-8d90-45ca-809f-85a0d6b90ced");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Time Beacon",
                Level = 7,
                Duration = "Until the end of your turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7155b82-e706-4270-a86b-b665ca889970"), Type = TextBlockType.Text, Text = "You create a beacon in time, intending to return to it if things go wrong. You can cast time beacon on only your turn. Keep careful track of everything that happens this turn after you cast time beacon. At the end of your turn, you can choose to rewind time back to just after you cast time beacon, removing all effects of your turn since then. Curses, traps, and other harmful effects that happen during your turn might prevent you from returning to the beacon if they are powerful enough. If you suffered any harmful effects during your turn after casting time beacon, to return to your beacon, time beacon attempts a counteract check against each such effect. If it fails at any of these checks, you can't return. After returning to the time beacon, the spell ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e9ead2ea-0836-4fe8-b177-edcbc2dc72f9"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0a1c78b-b609-429d-940c-f2cddac5584a"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 111
            };
        }
    }
}
