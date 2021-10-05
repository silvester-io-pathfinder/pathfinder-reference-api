using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FalseLife : Template
    {
        public static readonly Guid ID = Guid.Parse("4719507f-5377-4d5a-b25f-3cf5c51b16fb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "False Life",
                Level = 2,
                Duration = "8 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e928a4b3-0b13-4d33-93da-508862449e0a"), Type = TextBlockType.Text, Text = "You create a reservoir of vitality from necromantic energy, gaining a number of temporary Hit Points equal to 6 plus your spellcasting ability modifier." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7572f01f-f0fc-4e6b-b2a7-9e0673cbe233"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5406769c-d67d-4325-8212-ef122e102f53"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase by 3." }
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
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c823a3f-6845-4aee-a1d9-5a39aca8fa0f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
