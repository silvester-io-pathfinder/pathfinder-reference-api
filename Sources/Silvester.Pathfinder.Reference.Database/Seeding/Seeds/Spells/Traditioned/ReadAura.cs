using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ReadAura : Template
    {
        public static readonly Guid ID = Guid.Parse("94291c89-b56a-423e-b66f-bf04f06e1c97");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Read Aura",
                Level = 1,
                CastTime = "1 minute.",
                Range = "30 feet.",
                Targets = "1 object.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3733aa65-fc2f-4a07-838f-ea693b534ff7"), Type = TextBlockType.Text, Text = "You focus on the target object, opening your mind to perceive magical auras. When the casting is complete, you know whether that item is magical, and if it is, you learn the school of magic (pages 297–298 of the Core Rulebook)." };
            yield return new TextBlock { Id = Guid.Parse("d9e2d969-2f03-429e-aa39-73e198a8e0e2"), Type = TextBlockType.Text, Text = "If the object is illusory, you detect this only if the effect’s level is lower than the level of your read aura spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("199608f5-88e3-4f38-b25c-b0449e871059"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8769d89c-9f3d-4cf0-8ab6-b4670bcbe8d9"), Type = TextBlockType.Text, Text = "You can target up to 10 objects." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("053f2a5c-c62b-404c-a5e8-e747fdf5344a"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1af1dac2-654c-4fc2-8893-d9421f212cea"), Type = TextBlockType.Text, Text = "You can target any number of objects." }
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
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a23c6f67-c25a-46b0-a538-3bf199bfdb47"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
