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
    public class OnTheCase : Template
    {
        public static readonly Guid ID = Guid.Parse("f719af65-1f53-4cde-b169-9f2b5e13ae02");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "On the Case", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("72de874d-6efe-4844-92a8-175502e5c539"), Type = TextBlockType.Text, Text = "As an investigator, you think of your adventures as cases waiting to be solved. You gain one activity and one reaction you can use to investigate cases: Pursue a Lead and Clue In." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("022aca42-9ccd-4051-8e75-79c4ed53aeb0"), Feats.Instances.ClueIn.ID);
            builder.GainSpecificFeat(Guid.Parse("e4ee2285-0614-482d-948a-33915aa8abc0"), Feats.Instances.PursueALead.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64b060b5-b0df-48a7-b27f-491d146f10f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 56
            };
        }
    }
}
