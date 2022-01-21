using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class SharedVigilance : Template
    {
        public static readonly Guid ID = Guid.Parse("1ca3b06d-aad8-44fa-8184-add8e42f7f57");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Shared Vigilance", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("65ac2b3a-ed6f-496a-b9cc-bf92a58379f8"), Type = TextBlockType.Text, Text = "You and your eidolon work together to remain alert to threats around you, allowing you to perceive far more together than you could individually. Your proficiency rank in Perception and your eidolon's proficiency rank in Perception increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("39c5618e-7de1-4647-8215-f3e7f5fda210"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a37529d-0bb2-4967-b1ea-a95d0942f4c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
