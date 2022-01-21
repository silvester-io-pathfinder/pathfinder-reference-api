using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class InstantManifestation : Template
    {
        public static readonly Guid ID = Guid.Parse("0bfbeb64-efd2-42f5-aa9d-d08287a3f2d3");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Instant Manifestation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8ecc425c-319f-4348-9063-26613fcb91d2"), Type = TextBlockType.Text, Text = "You can manifest your eidolon with incredible speed. You can use Manifest Eidolon as a single action, instead of a three-action activity" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Modify feat effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3924602a-6785-4954-aaf5-e6b40f9e1ad1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
