using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ReadTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("9a5cfa37-5c82-426e-9d6d-f168e9fca73b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Read the Air",
                Level = 1,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3626a91-f7ab-42f7-9acc-99712f7e2ce9"), Type = TextBlockType.Text, Text = "You take a deep breath as you survey a social situation, showing courtesy to all around you as your intuition swiftly picks up clues about social contexts and unspoken assumptions of behavior. Your body language subconsciously changes to take advantage of this information and use it in your own interactions with those creatures." };
            yield return new TextBlock { Id = Guid.Parse("7782f382-1562-420a-aec5-7f0024015366"), Type = TextBlockType.Text, Text = "As part of Casting this Spell, you Recall Knowledge using Society to gain information about the immediate social situation. You also gain a +1 status bonus on your next Diplomacy check to Make an Impression on those creatures present when you cast this spell, as long as the check occurs during the duration of the spell. You can read the air only once in a given social situation; casting it again has no effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ff5ba76-b476-4632-80ca-9fbd562bf0e4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 125
            };
        }
    }
}
