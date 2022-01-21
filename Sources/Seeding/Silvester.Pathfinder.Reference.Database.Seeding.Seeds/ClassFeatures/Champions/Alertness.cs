using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class Alertness : Template
    {
        public static readonly Guid ID = Guid.Parse("1c16f43c-4161-4bd0-804c-9c7bcd1f5f70");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Alertness", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dee569b0-f35a-409b-8f70-065bd2d0a4c8"), Type = TextBlockType.Text, Text = "You remain alert to threats around you. Your proficiency rank for Perception increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("0ab924a5-c230-49ce-9175-69de838147cc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b8150e0-4978-4629-a049-72735977d68c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
