using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Bullhorn : Template
    {
        public static readonly Guid ID = Guid.Parse("3471dbf6-fcd2-4fcc-b5f3-3869eac67f92");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bullhorn",
                Level = 1,
                Duration = "10 minutes.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1fc3678-798c-4396-9123-a3ac703ec477"), Type = TextBlockType.Text, Text = "You amplify your voice, loud enough for you to be heard easily at a great distance. For the duration, your voice can be heard loudly and clearly by all listeners within 500 feet, even if other ambient noise would otherwise block the sound. Despite the volume, this doesn�t make your voice jarring or distracting. This doesn�t increase the range or area of other auditory or linguistic effects, and physical barriers such as walls and doors still block or muffle your voice as normal." };
            yield return new TextBlock { Id = Guid.Parse("c9b65f33-6a70-4256-8494-5dc1e1b822b7"), Type = TextBlockType.Text, Text = "Your loud voice makes it easier to Coerce others, and the acoustics assist in Performing at a large venue. You gain a +1 status bonus to checks to Coerce and auditory Performance checks to Perform at a large venue." };
            yield return new TextBlock { Id = Guid.Parse("746d5144-c888-450f-adac-d908cb3e3e8b"), Type = TextBlockType.Text, Text = "You can Dismiss the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a943e2d0-b854-409a-b841-88aa5ec01513"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1711cd3d-0cca-4b45-93cc-a5b924139b4a"), Type = TextBlockType.Text, Text = "Your voice can be heard clearly up to 1,200 feet away." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("56569e8a-05aa-4747-869e-a882f9de6b1f"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("0f750709-18a3-4387-b76d-7e24ff3ebbeb"), Type = TextBlockType.Text, Text = "Your voice can be heard clearly up to 1 mile away." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("aacdf0dc-f539-46a0-8541-1ffb7f695c9d"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("537ced75-0548-4515-94e6-4e783fcf6d03"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("476cca65-1c75-4435-889e-1ad73efee0cc"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f862562-a4a9-44ef-9857-280b37e21eda"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 93
            };
        }
    }
}
