using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ImprintMessage : Template
    {
        public static readonly Guid ID = Guid.Parse("790be85c-4568-4987-b951-a1a1a848bdea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Imprint Message",
                Level = 1,
                Range = "Touch.",
                Targets = "1 object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("daa8435c-eca0-4d4e-8fbb-4fed3621c106"), Type = TextBlockType.Text, Text = "You project psychic vibrations onto the target object, imprinting it with a short message or emotional theme of your design. This imprinted sensation is revealed to a creature who casts object reading (page 222) on the target object, replacing any emotional events the item was present for. If the object is in the area of a retrocognition spell, the imprinted messages appear as major events in the timeline, but they don’t interfere with any other visions." };
            yield return new TextBlock { Id = Guid.Parse("9d4d6fda-9360-40f9-9e02-95f486533597"), Type = TextBlockType.Text, Text = "If the object is targeted with read aura of a higher spell level than imprint message, the caster learns that the object has been magically modified. When you Cast this Spell, any prior vibrations placed on an object by previous castings of imprint message fade." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84d32a7e-67ba-4672-9f3a-7794b328176b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
