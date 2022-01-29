using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class VigilantSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("1b27423e-069e-42f8-b6ce-7930f3be3275");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Vigilant Senses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c5effe37-deb8-48ef-adbe-05cf33160bd0"), Type = TextBlockType.Text, Text = "Through your adventures, you've developed keen awareness and attention to detail. Your proficiency rank for Perception increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("a57b53b4-2384-4d64-b0c2-1636c9761d5d"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0367964e-8ae2-498a-8d8c-472137b48fe5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
