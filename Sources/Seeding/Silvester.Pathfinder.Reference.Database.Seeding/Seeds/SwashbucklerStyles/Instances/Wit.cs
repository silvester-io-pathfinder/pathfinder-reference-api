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
    public class Wit : Template
    {
        public static readonly Guid ID = Guid.Parse("efaf748d-760f-4eeb-b8f5-68b369f5c8aa");
        
        protected override SwashbucklersStyle GetSwashbucklersStyle()
        {
            return new SwashbucklersStyle
            {
                Id = ID, 
                Name = "Wit",
                Description = "You are friendly, clever, and full of humor, always knowing just what to say in any situation. Your witticisms leave foes unprepared for the skill and speed of your attacks. You are trained in Diplomacy and gain the Bon Mot skill feat. You gain panache during an encounter whenever you succeed at a Bon Mot against a foe.",
                ExemplaryFinisher = "The foe takes a �2 circumstance penalty to attack rolls against you until the start of your next turn."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("102c05d2-7982-4613-a013-d09ce03ac0b6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificFeat(Guid.Parse("57829245-3c9a-4c62-839b-8d5282e616f0"), Feats.Instances.BonMot.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe7eb972-6f6f-4552-bb49-dda733410495"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
