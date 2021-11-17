using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TreeStride : Template
    {
        public static readonly Guid ID = Guid.Parse("349ed613-7398-4320-8d2f-456481a6d593");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tree Stride",
                Level = 5,
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6dcf1a44-9039-4ddb-a84d-bd3f821ddf37"), Type = TextBlockType.Text, Text = "You step into a living tree with a trunk big enough for you to fit inside it and instantly teleport to any tree of the same species within 5 miles that also has a sufficiently large trunk. Once you enter the first tree, you instantly know the rough locations of other sufficiently large trees of the same species within range and can exit from the original tree, if you prefer. You can’t carry extradimensional spaces with you; if you attempt to do so, the spell fails." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f8edbf50-c335-40f1-bbea-1839b6a3c394"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2d63ca7c-f156-482f-ba76-6ec0f923e91b"), Type = TextBlockType.Text, Text = "The tree you exit can be up to 50 miles away." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7fea0424-3dec-4090-b2e8-593839a8879b"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a7e3038a-6005-47bc-93e7-326710b30256"), Type = TextBlockType.Text, Text = "The tree you exit can be up to 500 miles away." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9aa92ab-211c-4777-93e6-82c44c7292a3"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("29049625-cd6e-40c5-bfc8-57a1a0f809c8"), Type = TextBlockType.Text, Text = "The tree you exit can be anywhere on the same planet." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d1b274e-8d9e-4e3b-82f3-abfa8bfc595c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
