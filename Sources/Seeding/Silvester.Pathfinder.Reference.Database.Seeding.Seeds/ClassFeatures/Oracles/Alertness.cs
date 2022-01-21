using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class Alertness : Template
    {
        public static readonly Guid ID = Guid.Parse("efc91724-13db-40c2-a591-d52939a1450f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Alertness", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f535a655-3546-47fc-bb65-6ec40fe88e4d"), Type = TextBlockType.Text, Text = "You remain alert to threats around you. Your proficiency rank for Perception increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("5dd00b14-cd40-499e-87de-01faeb40cbc7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0604891d-531f-4726-969c-0cdef919a6fd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
