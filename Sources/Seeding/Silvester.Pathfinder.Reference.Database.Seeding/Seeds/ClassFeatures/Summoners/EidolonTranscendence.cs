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
    public class EidolonTranscendence : Template
    {
        public static readonly Guid ID = Guid.Parse("de6799bc-bb45-4d9d-b738-2cd900bae598");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Eidolon Transcendence", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("36d260de-8c3b-4057-8bf8-78b0467ec834"), Type = TextBlockType.Text, Text = "Your connection with your eidolon approaches its peak, granting your eidolon access to a powerful new ability depending on its type, as described in Eidolon Abilities in each eidolon's entry. This ability also increases one of the eidolon's ability scores by 2." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Handled by Eidolon class feat.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2017335d-3c07-4b70-8452-f6c44253f6b9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
