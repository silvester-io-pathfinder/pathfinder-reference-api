using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CozyCabin : Template
    {
        public static readonly Guid ID = Guid.Parse("99e445a2-b97d-41b7-81dd-7b0aea1e35b9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cozy Cabin",
                Level = 3,
                CastTime = "1 minute.",
                Range = "30 feet.",
                Duration = "12 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4ab7172-9b47-4f13-83d3-ea87ce9af004"), Type = TextBlockType.Text, Text = "You shape a cabin 20 feet on each side and 10 feet high. This cabin has the structure trait and the same restrictions as magic items that create structures. The walls of the hut are simple and wooden, with small, square glass windows, and it has one wooden door. It doesn't include its own lock, but it has a fastener to which a lock can be applied." };
            yield return new TextBlock { Id = Guid.Parse("14a68088-3471-4197-97c7-b86b87f249c5"), Type = TextBlockType.Text, Text = "The interior contains three cots, one chamber pot, and a small fireplace holding a magical fire. The interior is lit with a small magical light that you can light or extinguish at will using a single action, which has the concentrate trait. The climate inside the hut is comfortable and allows creatures inside it to withstand most hostile weather conditions, but incredible heat or cold, powerful storms, and winds of hurricane force or greater destroy the hut. Other creatures can freely enter and exit the hut without damaging it, but if you exit the hut, the spell ends. You can Dismiss the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("070a3086-5dba-48a6-b3c5-d7bb5f0cd37e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
