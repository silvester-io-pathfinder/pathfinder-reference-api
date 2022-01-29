using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class VigilantSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("d406e100-0dea-41d8-a46e-4f0815aed0e2");

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
            yield return new TextBlock { Id = Guid.Parse("f2aef13d-c04b-4913-ae50-690bb4bc6a59"), Type = TextBlockType.Text, Text = "Through your adventuring, you've developed keen awareness and attention to detail. Your proficiency rank for Perception increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("2d93d0a3-7d74-463f-8538-fd0daf24b477"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e867309-aeed-4576-b7c6-ff39b0b0fcd8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
