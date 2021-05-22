using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RemoveFear : Template
    {
        public static readonly Guid ID = Guid.Parse("ff672805-46a4-459d-881a-41bd1aee7d2b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Remove Fear",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d447c2a-fb83-4616-be54-c04fd321a47a"), Type = TextBlockType.Text, Text = "With a touch, you ease a creature’s fears. You can attempt to counteract a single fear effect that the target suffers from. This frees only the target, not any other creatures under the fear effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b62a4d3a-507b-460e-bc0d-e48fad404ee3"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cc9285bf-aecb-4f35-a672-fbe397e49794"), Type = TextBlockType.Text, Text = "The spell’s range increases to 30 feet, and you can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08fdc848-d361-4c19-ad19-1f058ea80fd5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
