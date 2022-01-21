using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class Innovation : Template
    {
        public static readonly Guid ID = Guid.Parse("9d30f960-6b90-40b3-a7b3-a0501be10e14");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Innovation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4ddc35d0-1aae-4ae5-9472-02d8bf301243"), Type = TextBlockType.Text, Text = "While you're always creating inventions, there's one that represents your preeminent work, the one that you hope� with refinement�might change the world. Choose one innovation. Your innovation's level is equal to your level. If your innovation is destroyed, you can spend 1 day of downtime and attempt a Crafting check with a high DC for your level; on a success, you rebuild it. An innovation only works due to your constant maintenance and tinkering, and therefore has no market Price." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyInnovation(Guid.Parse("46ff472b-7255-499e-bf94-74c58c0a240a"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0eefea1-2d19-483e-aa72-eec7912a93be"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
