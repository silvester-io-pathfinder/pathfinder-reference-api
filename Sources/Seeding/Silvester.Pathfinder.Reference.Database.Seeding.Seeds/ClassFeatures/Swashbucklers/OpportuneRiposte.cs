using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class OpportuneRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("a29d40bb-8d0b-45a6-8408-48d7a1a3d69e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Opportune Riposte", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("46ae1b05-b2f0-4e74-98f2-774074a85c4b"), Type = TextBlockType.Text, Text = "You turn the tables on foes who fumble, capitalizing immediately on their mistake. You gain the Opportune Riposte reaction." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("b260f994-e40c-4b06-9849-aced0aec7827"), Feats.Instances.OpportuneRiposte.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bce9a283-8e23-48ab-8207-69d82e9cfa76"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
