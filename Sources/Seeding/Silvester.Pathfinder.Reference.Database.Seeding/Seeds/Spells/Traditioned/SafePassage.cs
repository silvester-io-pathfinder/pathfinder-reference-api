using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SafePassage : Template
    {
        public static readonly Guid ID = Guid.Parse("a81fcdf7-416e-4f72-8bdc-6e2f84329f20");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Safe Passage",
                Level = 3,
                Range = "Touch.",
                Area = "10-foot-wide, 10-foot tall, 60-foot-long section of terrain.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7496181-7f02-467a-a0a2-153266044b2f"), Type = TextBlockType.Text, Text = "You repel dangers from all around you, making passage through the chosen area safe for a brief amount of time. Anyone passing through the area gains the following benefits against harmful effects of the terrain and environment, including environmental damage, hazardous terrain, and hazards in the area. The spell grants a +2 status bonus to AC and saves against such effects, and resistance 5 to all damage from such effects. Furthermore, the spell prevents anything in the area that's prone to collapse, such as a rickety bridge or an unstable ceiling, from collapsing, except under extreme strain that would collapse a normal structure of its type." };
            yield return new TextBlock { Id = Guid.Parse("23c66b8a-71cb-4c67-a915-989a796079ab"), Type = TextBlockType.Text, Text = "Safe passage protects only against harm, not inconvenience, and it doesn't reduce difficult terrain, remove the concealed condition caused by precipitation, or the like, nor does it protect against creatures within the spell's area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b8d17de0-d863-4976-b3b2-bc151ff62f8e"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bd7940d5-804f-44fa-9363-1b3ccf9ce5c4"), Type = TextBlockType.Text, Text = "The granted resistance increases to 10, and the area can be 120 feet long." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("18b2c0f9-71e9-4818-a597-7644fa509508"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7786797c-4bb1-4cc2-88c2-765d54ad61af"), Type = TextBlockType.Text, Text = "The granted resistance increases to 15, and the area can be 500 feet long." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4672438-eb46-440a-a644-f93ec65c9b81"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 224
            };
        }
    }
}
