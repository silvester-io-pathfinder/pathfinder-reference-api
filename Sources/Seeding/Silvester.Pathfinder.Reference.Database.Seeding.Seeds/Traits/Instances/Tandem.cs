using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Tandem : Template
    {
        public static readonly Guid ID = Guid.Parse("4aa2abcf-66ec-48df-a421-e40516017bb3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tandem",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8efbb490-7a09-41bb-ae75-50edb41e84b2"), Type = TextBlockType.Text, Text = "Actions with this trait involve you and your eidolon acting in concert. You can't use a tandem action if either you or your eidolon can't act, if you haven't Manifested your Eidolon, or if you've Manifested your Eidolon in a way where it isn't a separate entity (such as with the Meld into Eidolon feat). Tandem actions often let both you and your eidolon take separate actions, but these must be actions taken separately by you and your eidolon; you can't use a tandem action to take another tandem action." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af49790b-98bf-44d3-8f4d-7162f36b3a9a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
