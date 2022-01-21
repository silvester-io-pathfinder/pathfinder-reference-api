using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class ResearchField : Template
    {
        public static readonly Guid ID = Guid.Parse("343b8e67-0c66-41c6-8ce1-2bbe86874330");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Research Field", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1e146146-629a-4b0a-958d-6635b227f0bf"), Type = TextBlockType.Text, Text = "Your inquiries into the alchemical nature of the universe have led you to focus on a particular field of research. You might have a degree from a scientific institute, correspond with other researchers in your field, or work as a genius loner. Choose a field of research." };
            yield return new TextBlock { Id = Guid.Parse("fd573d5c-fc09-43ab-bb4b-95d7a3d71afe"), Type = TextBlockType.Text, Text = "Your research field adds a number of formulas to your formula book; these are your signature items. When using a batch of infused reagents to create your signature items using advanced alchemy, you create three items instead of two. Each time you gain a level, you can swap one of your signature items with another formula in your formula book. This new signature item must be on your research field's list of possible signature items." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyResearchField(Guid.Parse("2a750bb6-56eb-4b05-8bd4-eb0d5558fd9e"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15141d22-fa10-4bca-b294-24b28b104d3b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
