using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SeashellOfStolenSound : Template
    {
        public static readonly Guid ID = Guid.Parse("0fc062cc-cb7f-49ca-8b5c-1b871cd584de");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Seashell of Stolen Sound",
                Level = 1,
                Range = "30 feet.",
                Trigger = "A creature within range begins to make a sound.",
                Duration = "Until your next daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("878eed60-f38f-453f-811f-1117beda0576"), Type = TextBlockType.Text, Text = "You store a sound in a seashell to use as you will: the last words of a loved one, a dragon's mighty roar, the compromising conversation between two powerful diplomats, or even more strange and secret. As part of Casting this Spell, you must present an unbroken seashell. When you Cast the Spell, magic swirls around the triggering creature, copying the sounds they make, as well as any background noise, for the next minute and storing them in the seashell." };
            yield return new TextBlock { Id = Guid.Parse("fca37c88-83cd-485f-97ea-221f7c7c5267"), Type = TextBlockType.Text, Text = "You or another creature can then play the sound back from the seashell during the spell's duration by Interacting with the seashell, but once the sounds have been played back, the seashell shatters and the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("be2fc49a-e109-4731-b8f5-47af7bd09a87"), Type = TextBlockType.Text, Text = "As normal for spells with a duration until your next daily preparations, you can choose to continue expending the spell slot to prolong the duration of an existing seashell of stolen sound for another day. While the spell faithfully copies the sounds around the target, it doesn't reproduce any special auditory or sonic effects of the sound." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Focus.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("89238ac7-04df-430d-a0f8-2c99c64ec3f2"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("ea700b69-a853-4fc9-b0b2-3c681979155a"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf2544fb-37e1-432c-ad4a-7683a6eedc76"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 127
            };
        }
    }
}
