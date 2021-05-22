using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Multiclass : Template
    {
        public static readonly Guid ID = Guid.Parse("464d7ccc-ef65-4eac-967c-6066156f88fb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Multiclass",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d79321ae-a3a2-41f4-a36b-61298b27d83e"), Type = TextBlockType.Text, Text = "Archetypes with the multiclass trait represent diversifying your training into another class’s specialties. You can’t select a multiclass archetype’s dedication feat if you are a member of the class of the same name." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b54a005f-5c8f-40c1-bd5b-a5158f16b055"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
