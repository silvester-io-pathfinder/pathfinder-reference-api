using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StormLord : Template
    {
        public static readonly Guid ID = Guid.Parse("6e915e86-4958-40eb-a661-ef6e6e4daf03");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Storm Lord",
                Level = 9,
                Requirements = "You are outdoors and aboveground.",
                Area = "100-foot emanation, which affects you.",
                IsDismissable = true,
                Duration = "Sustainted up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ebd1aa4-b563-460f-8590-f4441506b3de"), Type = TextBlockType.Text, Text = "The sky above you darkens in a matter of moments, swirling with ominous clouds punctuated by flashes of lighting. The first time each round you Sustain the Spell, you can select one of the following effects to occur in the area." };
            yield return new TextBlock { Id = Guid.Parse("e3ebcefc-3129-4d33-b300-01b934c52a0e"), Type = TextBlockType.Enumeration, Text = "Calm - No additional effect." };
            yield return new TextBlock { Id = Guid.Parse("19d5214a-81d5-4d59-9598-eb6adaf621b5"), Type = TextBlockType.Enumeration, Text = "Fog - Heavy fog rolls in, concealing the area with the effects of obscuring mist." };
            yield return new TextBlock { Id = Guid.Parse("4dddead1-1c10-4835-baab-2bc615e241bf"), Type = TextBlockType.Enumeration, Text = "Rain - Torrential rain falls from the sky, dousing ordinary flames. Creatures in the area take a –2 circumstance penalty to Acrobatics and Perception checks." };
            yield return new TextBlock { Id = Guid.Parse("3d58fb86-0b71-4f4b-97c8-963343a7bc4e"), Type = TextBlockType.Enumeration, Text = "Wind - Powerful winds buffet the area in all directions. Ranged attacks take a –4 circumstance penalty, and all flying is against the wind and counts as moving through difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("a60f4956-d43b-4501-9757-4076fcf6f9c5"), Type = TextBlockType.Text, Text = "In addition, once per round you can use a single action, which has the concentrate and manipulate traits, to call down a bolt of lightning, striking any target in range that you can see. You deal 10d6 electricity damage to the target; it must attempt a basic Reflex save. On a failure, it is also deafened for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae9b117c-3b50-4ee6-a89b-afe3730dc561"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
