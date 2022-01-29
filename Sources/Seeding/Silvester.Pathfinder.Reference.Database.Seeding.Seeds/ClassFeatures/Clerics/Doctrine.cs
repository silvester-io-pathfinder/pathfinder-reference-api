using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class Doctrine : Template
    {
        public static readonly Guid ID = Guid.Parse("b0a662cc-5636-4f6d-961e-644799ccbc42");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Doctrine", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3e9b1352-7b49-4952-8d58-025c793d4d77"), Type = TextBlockType.Text, Text = "Even among followers of the same deity, there are numerous doctrines and beliefs, which sometimes vary wildly between clerics. At 1st level, you select a doctrine and gain the benefits of its first doctrine. The doctrines presented in this book are cloistered cleric and warpriest. Each doctrine grants you initial benefits at 1st level. At 3rd, 7th, 11th, 15th, and 19th levels, you gain the benefits granted by your doctrine's second, third, fourth, fifth, and final doctrines respectively." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDoctrine(Guid.Parse("21c2aa9b-4b21-4cb9-bb24-c6da7230c2f7"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a36daf2-80a3-47cc-a32f-42b852385be0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 119
            };
        }
    }
}
