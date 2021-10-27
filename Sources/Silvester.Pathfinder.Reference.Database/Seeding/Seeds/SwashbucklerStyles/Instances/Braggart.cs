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
    public class Braggart : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override SwashbucklersStyle GetSwashbucklersStyle()
        {
            return new SwashbucklersStyle
            {
                Id = ID, 
                Name = "Braggart",
                Description = "You boast, taunt, and psychologically needle your foes. You are trained in Intimidation. You gain panache during an encounter whenever you successfully Demoralize a foe.",
                ExemplaryFinisher = "If the foe was temporarily immune to your Demoralize, their temporary immunity ends."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
