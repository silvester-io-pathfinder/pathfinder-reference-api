using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HallucinatoryTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("00331151-20c7-4dfb-9198-eb1726b68b73");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hallucinatory Terrain",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "500 feet.",
                Area = "50-foot burst.",
                Duration = "Until the next time you make your daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("317d519e-75c2-4cb2-96a3-3ab65926c0af"), Type = TextBlockType.Text, Text = "You create an illusion that causes natural terrain to look, sound, feel, and smell like a different kind of terrain. This doesn’t disguise any structures or creatures in the area." };
            yield return new TextBlock { Id = Guid.Parse("74f79956-e3fa-46f2-a76f-61ed5c54d1d6"), Type = TextBlockType.Text, Text = "Any creature that touches the illusion or uses the Seek action to examine it can attempt to disbelieve your illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1537de16-e316-41d3-a950-69eceb025c72"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("85192c26-f57a-44f8-b5e8-b2d0eb0906d9"), Type = TextBlockType.Text, Text = "Your image can also disguise structures or create illusory structures (but still doesn’t disguise creatures)." }
                }
            };
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac1e9f23-d1ae-400e-91e0-64fd71c19e36"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
