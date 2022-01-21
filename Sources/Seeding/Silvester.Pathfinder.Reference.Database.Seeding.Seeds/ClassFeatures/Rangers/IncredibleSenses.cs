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
    public class IncredibleSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("f1c9ad61-c8e1-4a58-8e6d-85fb2d844cc6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Incredible Senses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f299be04-0984-4bdd-b79f-db1221989e53"), Type = TextBlockType.Text, Text = "You notice things almost impossible for an ordinary person to detect. Your proficiency rank for Perception increases to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("7c3d205b-9458-4905-8282-a1fa3b95c3a2"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08beb50c-d653-4fd1-8d40-2675c91f3974"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 170
            };
        }
    }
}
