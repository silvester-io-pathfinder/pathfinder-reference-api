using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class Instinct : Template
    {
        public static readonly Guid ID = Guid.Parse("8e311867-d2bb-4f44-a1f5-e0694256ef44");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Instinct", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e05f3865-6935-40b6-a0ca-9b04325f5f3a"), Type = TextBlockType.Text, Text = "Your rage wells up from a dominant instinct�one you learned from a tradition or that comes naturally to you. Your instinct gives you an ability, requires you to avoid certain behaviors, grants you increased damage and resistances at higher levels, and allows you to select feats tied to your instinct." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyInstinct(Guid.Parse("fbda0a9f-f849-401b-80bd-fc743afa20d3"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a7bc9f9-e1ce-4e18-b7a9-9a8bb51f0805"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
