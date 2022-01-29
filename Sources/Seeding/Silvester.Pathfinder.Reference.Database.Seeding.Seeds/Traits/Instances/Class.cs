using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Class : Template
    {
        public static readonly Guid ID = Guid.Parse("c1b040be-00d4-470b-a3c2-7ffc260d82d1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Class",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0563cb4-90f7-4e92-9e7a-9eaf7aa5ec00"), Type = TextBlockType.Text, Text = "Archetypes with the class trait fundamentally diverge from your class's specialties but still fit within the theme of your class." };
            yield return new TextBlock { Id = Guid.Parse("d973e63b-410e-4ed7-b337-5f469f0ebd9f"), Type = TextBlockType.Text, Text = "You can select a class archetype only if your class meets the criteria listed in the archetype's prerequisites. Class archetypes always alter or replace some of a class's static class features in addition to any new feats they offer." };
            yield return new TextBlock { Id = Guid.Parse("e45eba39-222e-4830-a6dd-a3433691d6bc"), Type = TextBlockType.Text, Text = "It might be possible to take a class archetype at 1st level if it alters or replaces some of the class's initial class features. The 1st-level ability is presented much like a class feature and includes the class archetype's prerequisites and rules on how it changes your class. If you select this ability, you must take that archetype's dedication feat at 2nd level, and you proceed normally afterward. You can never have more than one class archetype." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1f56632-eb17-4501-bfed-bfef5d3755e5"),
                SourceId = Sources.Instances.Pathfinder151.ID,
                Page = 60
            };
        }
    }
}
