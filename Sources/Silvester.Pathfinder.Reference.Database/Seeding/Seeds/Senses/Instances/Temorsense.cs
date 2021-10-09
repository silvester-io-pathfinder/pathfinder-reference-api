using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Temorsense : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Temorsense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Tremorsense allows a creature to feel the vibrations through a solid surface caused by movement. It is usually an imprecise sense with a limited range (listed in the ability). Tremorsense functions only if the detecting creature is on the same surface as the subject, and only if the subject is moving along (or burrowing through) the surface." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
