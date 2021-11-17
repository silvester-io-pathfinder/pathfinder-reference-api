using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SwashbucklerStyles.Instances
{
    public class Fencer : Template
    {
        public static readonly Guid ID = Guid.Parse("85db8b71-ee27-481d-83f1-808bbbb2d647");
        
        protected override SwashbucklersStyle GetSwashbucklersStyle()
        {
            return new SwashbucklersStyle
            {
                Id = ID, 
                Name = "Fencer",
                Description = "You move carefully, feinting and creating false openings to lead your foes into inopportune attacks. You are trained in Deception. You gain panache during an encounter whenever you successfully Feint or Create a Diversion against a foe.",
                ExemplaryFinisher = "The foe is flat-footed until your next turn."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("7baf2af5-bcd8-4df5-882c-c4e1268d4eb0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07b75e81-6c04-435a-a1ea-19f2ec828874"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
