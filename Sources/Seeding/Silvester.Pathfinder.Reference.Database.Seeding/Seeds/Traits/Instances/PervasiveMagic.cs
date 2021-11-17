using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class PervasiveMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("f0f4168b-9682-41df-a558-b2bd2cb94805");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Pervasive Magic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3cfe53e-6e6a-4557-97eb-ee10f3bfea2e"), Type = TextBlockType.Text, Text = "No description was provided for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20b3e0a6-210a-43ae-8cb3-11293e9929d2"),
                SourceId = SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
