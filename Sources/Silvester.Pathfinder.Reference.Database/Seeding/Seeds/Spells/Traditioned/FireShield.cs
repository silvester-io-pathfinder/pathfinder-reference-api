using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FireShield : Template
    {
        public static readonly Guid ID = Guid.Parse("fee3de9b-978f-4f95-b5f6-12241d27bbc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fire Shield",
                Level = 4,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c93c3fcf-3ce0-478a-b7cd-6e791fbd230c"), Type = TextBlockType.Text, Text = "You wreathe yourself in ghostly flames, gaining cold resistance 5. Additionally, adjacent creatures that hit you with a melee attack, as well as creatures that touch you or hit you with an unarmed attack, take 2d6 fire damage each time they do." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3d537f08-a96a-4364-bc75-ec338ceb1a2d"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("76506290-68d9-467a-b662-0fd604950097"), Type = TextBlockType.Text, Text = "The cold resistance increases by 5, and the fire damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("246ddeb3-5c6b-4d56-bf87-06edfa2d3d1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
