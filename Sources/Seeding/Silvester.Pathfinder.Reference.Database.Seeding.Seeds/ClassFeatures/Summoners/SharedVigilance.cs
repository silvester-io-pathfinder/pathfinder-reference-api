using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SharedVigilance : Template
    {
        public static readonly Guid ID = Guid.Parse("1efd14ac-543b-45f1-aa2c-f0029b4512b1");

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
            yield return new TextBlock { Id = Guid.Parse("c2285666-7072-4084-bcea-2f83cc197dc0"), Type = TextBlockType.Text, Text = "You and your eidolon work together to remain alert to threats around you, allowing you to perceive far more together than you could individually. Your proficiency rank in Perception and your eidolon's proficiency rank in Perception increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("74499de3-38c9-4e3a-8aa7-bad9f34784bc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dee49730-c9d9-4d12-b49c-a34f88863e9e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
