using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Abilities.Instances
{
    public class Darkvision : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Darkvision"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A monster with darkvision can see perfectly well in areas of darkness and dim light, though such vision is in black and white only. Some forms of magical darkness, such as a 4th-level darkness spell, block normal darkvision. A monster with greater darkvision, however, can see through even these forms of magical darkness." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
