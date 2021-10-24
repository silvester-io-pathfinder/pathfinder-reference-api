using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionDoor : Template
    {
        public static readonly Guid ID = Guid.Parse("73180f19-0c26-4f90-b377-8ae1d3df6525");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dimension Door",
                Level = 4,
                Range = "120 feet.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc66f243-805d-4d6f-93c2-8e9c12d6cf52"), Type = Utilities.Text.TextBlockType.Text, Text = "Opening a door that bypasses normal space, you instantly transport yourself and any items you’re wearing and holding from your current space to a clear space within range you can see.If this would bring another creature with you—even if you’re carrying it in an extradimensional container—the spell is lost." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4d38efb2-763a-44c6-97d6-f67dccc6e8c2"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("730ac659-7199-4a9f-a784-76fa50311b10"), Type = Utilities.Text.TextBlockType.Text, Text = "The range increases to 1 mile. You don’t need to be able to see your destination, as long as you have been there in the past and know its relative location and distance from you. You are temporarily immune for 1 hour." }
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("074afcf5-3f3c-4ac2-bd0f-c82b14cc8439"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
