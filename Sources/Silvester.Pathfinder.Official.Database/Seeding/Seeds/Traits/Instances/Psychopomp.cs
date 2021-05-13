using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Psychopomp : Template
    {
        public static readonly Guid ID = Guid.Parse("9a113e60-55b3-47ae-af56-39d8acb42e34");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Psychopomp",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12597cc7-67aa-46e8-8dfa-c490ede0b459"), Type = TextBlockType.Text, Text = "A family of monitors spawned within the Boneyard to convey souls to the Outer Planes, most psychopomps are true neutral. They typically have darkvision, lifesense, and spirit touch, and they are immune to death effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82a05a2b-6963-471f-9e96-13ecbfa19aaa"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
