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
    public class Gymnast : Template
    {
        public static readonly Guid ID = Guid.Parse("bc7d630d-6a9e-43bb-89f4-ebe68d2de313");
        
        protected override SwashbucklersStyle GetSwashbucklersStyle()
        {
            return new SwashbucklersStyle
            {
                Id = ID, 
                Name = "Gymnast",
                Description = "You reposition, maneuver, and bewilder your foes with daring feats of physical prowess. You are trained in Athletics. You gain panache during an encounter whenever you successfully Grapple, Shove, or Trip a foe.",
                ExemplaryFinisher = "If the foe is grabbed, restrained, or prone, you gain a circumstance bonus to the damage roll equal to twice the number of weapon damage dice."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("1c448a62-235f-495f-bf73-abb034b0c9d9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00a39485-d5e2-4ea2-96f9-1714df316386"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
