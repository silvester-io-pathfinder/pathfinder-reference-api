using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class VigilantSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("aac918ac-a7f1-4046-abaf-301d922ca78d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Vigilant Senses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9e303b16-2337-4c4e-bbfb-abc7c3b1c843"), Type = TextBlockType.Text, Text = "hrough your adventuring, you've developed keen awareness and attention to detail. Your proficiency rank for Perception increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("39704698-500e-4b97-919e-da184d8486ef"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20e9f848-cf94-4334-82d6-409f15a4fc49"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
