using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class Methodology : Template
    {
        public static readonly Guid ID = Guid.Parse("b99de160-0976-4647-b2a5-e462c4c4e74e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Methodology", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cdec523a-7692-4c25-949a-e8f398050720"), Type = TextBlockType.Text, Text = "Your studies have made you savvy in many areas, but one in particular drew your intense interest. Choose a methodology. The methodologies presented in this book are as follows." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMethodology(Guid.Parse("b2976859-0a5c-4aa6-837a-8b4b2b952bca"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7b87333-7f89-4a71-96b8-563ed9f9d71d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 57
            };
        }
    }
}
