using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaticImage : Template
    {
        public static readonly Guid ID = Guid.Parse("be30d9d6-9b39-4827-bbd2-2472b0dade9f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chromatic Image",
                Level = 6,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b9b651c-43d8-449e-b670-280b9691d3c8"), Type = TextBlockType.Text, Text = "You call forth three illusory images of yourself, and each of the four of you takes on a different color, your colors all shifting each time someone attacks you. This has the effects of mirror image, except that whenever a foe destroys one of the images, roll 1d4 to see which color the image was when it was destroyed. The attacker takes the corresponding effect." };
            yield return new TextBlock { Id = Guid.Parse("4e6fcee7-8537-466d-be20-6aa196ed18a1"), Type = TextBlockType.Enumeration, Text = "1. Red - 5 fire damage and 5 mental damage." };
            yield return new TextBlock { Id = Guid.Parse("7ff94084-13e6-42b0-90c4-5341624d72b7"), Type = TextBlockType.Enumeration, Text = "2. Orange - 5 acid damage and 5 mental damage." };
            yield return new TextBlock { Id = Guid.Parse("10483d32-f0eb-4e62-9590-9b86ad59883e"), Type = TextBlockType.Enumeration, Text = "3. Yellow - 5 electricity damage and 5 mental damage." };
            yield return new TextBlock { Id = Guid.Parse("57e3a906-c346-4929-8d02-6969e2c19199"), Type = TextBlockType.Enumeration, Text = "4. Green - 5 poison damage and 5 mental damage, plus it's frightened 1." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b405af32-c23b-4a86-944b-21eb6f866fe2"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("c0ca1065-bbfa-4cf2-a518-d08a4d36221c"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cf81ca4-82c3-4142-b834-09c051a2ed59"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 95
            };
        }
    }
}
