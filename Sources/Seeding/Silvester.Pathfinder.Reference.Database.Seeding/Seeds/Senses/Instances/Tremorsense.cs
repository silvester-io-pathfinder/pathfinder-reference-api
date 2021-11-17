using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Tremorsense : Template
    {
        public static readonly Guid ID = Guid.Parse("2d2f1105-5d1e-49be-83ab-da11886f54a0");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Tremorsense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24241de5-f133-4521-9c4e-6e9d34af9e3f"), Type = TextBlockType.Text, Text = "Tremorsense allows a creature to feel the vibrations through a solid surface caused by movement. It is usually an imprecise sense with a limited range (listed in the ability). Tremorsense functions only if the detecting creature is on the same surface as the subject, and only if the subject is moving along (or burrowing through) the surface." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76c95d77-5ed6-41b3-9eb7-ee59b7f45023"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
