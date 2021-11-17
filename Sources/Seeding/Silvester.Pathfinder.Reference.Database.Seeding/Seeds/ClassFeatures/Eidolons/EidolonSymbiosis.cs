using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class EidolonSymbiosis : Template
    {
        public static readonly Guid ID = Guid.Parse("a34651ef-f848-4da3-ad60-4f2213688d97");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Eidolon Symbiosis", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2ef20616-1fe3-4a66-b11f-da2a750c24ff"), Type = TextBlockType.Text, Text = "Your connection with your eidolon strengthens, granting your eidolon access to a new ability depending on its type, as described in Eidolon Abilities in each eidolon's entry." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Handled by the specific Eidolon.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d919864d-6df2-448b-99a4-853af137e491"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
