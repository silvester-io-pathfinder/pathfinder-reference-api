using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Sending : Template
    {
        public static readonly Guid ID = Guid.Parse("2f7a2088-4d0e-40d1-aa35-bd9105582fa1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sending",
                Level = 5,
                Range = "Planetary",
                Targets = "1 creature with whom you are familiar.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cff51bed-0e6e-4fc7-aa2f-99f7ac5e3205"), Type = TextBlockType.Text, Text = "You send the creature a mental message of 25 words or fewer, and it can respond immediately with its own message of 25 words or fewer." };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e9bf8eb-b62d-4294-bbff-ba320baccc81"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
