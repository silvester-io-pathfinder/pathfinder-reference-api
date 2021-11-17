using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class GreaterDarkvision : Template
    {
        public static readonly Guid ID = Guid.Parse("dd38b98e-73e7-495d-9005-9409c1758978");

        public override Sense GetSense()
        {
            return new Sense
            {
                Id = ID,
                Name = "Greater Darkvision"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b47f0a9-718b-4685-83ab-da6fc201c1a5"), Type = TextBlockType.Text, Text = "A monster with darkvision can see perfectly well in areas of darkness and dim light, though such vision is in black and white only. Some forms of magical darkness, such as a 4th-level darkness spell, block normal darkvision. A monster with greater darkvision, however, can see through even these forms of magical darkness." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6d473de-74e8-44d5-9873-468cfcc02afc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
