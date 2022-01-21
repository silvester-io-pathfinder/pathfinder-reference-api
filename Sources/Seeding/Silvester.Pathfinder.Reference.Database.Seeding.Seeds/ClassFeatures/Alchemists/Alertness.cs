using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class Alertness : Template
    {
        public static readonly Guid ID = Guid.Parse("7ebfdc1d-efc3-40be-803c-a98f586937cb");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Alertness", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("50d92925-6a05-4cc3-bc3b-8e492dbd1f9d"), Type = TextBlockType.Text, Text = "You remain alert to threats around you. Your proficiency rank for Perception increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("455908ed-9949-4e72-a991-deb42d7864a0"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("effc198e-64a2-40b5-b226-0f5bb615c3b4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
