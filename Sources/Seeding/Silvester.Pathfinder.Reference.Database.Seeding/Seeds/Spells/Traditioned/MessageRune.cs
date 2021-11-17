using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MessageRune : Template
    {
        public static readonly Guid ID = Guid.Parse("7a909e7b-1484-41d0-b68e-c0ec39c6ec90");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Message Rune",
                Level = 1,
                Range = "Touch.",
                Duration = "1 day.",
                Targets = "1 flat unattended surface.",
                CastTime = "5 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93f9dcb4-51f9-4174-b1eb-1b693a840c96"), Type = TextBlockType.Text, Text = "You record a message up to 5 minutes long and inscribe a special rune on any flat unattended surface within reach. The nature of the rune�s appearance is up to you, but it is visible to everyone and it must be no smaller than 2 inches in diameter. You also specify a trigger that creatures must meet to activate the rune. For the duration of the spell, creatures who meet the criteria of the trigger can touch the rune to hear the recorded message in their head as though you were speaking to them telepathically. You know when someone is listening to the message, but you do not know who is listening to it. You can Dismiss the spell." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7aebb7a-1160-4d68-bebd-9a9d4f2e01c7"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 108
            };
        }
    }
}
