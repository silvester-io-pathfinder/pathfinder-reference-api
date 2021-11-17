using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class IncredibleSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("6a118bf4-f30d-4ec6-9593-be2baff52043");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Incredible Senses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("063c15f9-53cf-4ad6-ab7d-dce3b8df449d"), Type = TextBlockType.Text, Text = "You notice things that most people can't detect. Your proficiency rank for Perception increases to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("ac1b437e-b50a-4f46-b225-98008197138f"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2085b46a-b36e-4a51-b9ff-27beedd3162f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 108
            };
        }
    }
}
