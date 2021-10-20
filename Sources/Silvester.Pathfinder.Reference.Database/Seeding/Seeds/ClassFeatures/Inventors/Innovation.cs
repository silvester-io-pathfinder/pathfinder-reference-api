using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class Innovation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While you're always creating inventions, there's one that represents your preeminent work, the one that you hope— with refinement—might change the world. Choose one innovation. Your innovation's level is equal to your level. If your innovation is destroyed, you can spend 1 day of downtime and attempt a Crafting check with a high DC for your level; on a success, you rebuild it. An innovation only works due to your constant maintenance and tinkering, and therefore has no market Price." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyInnovationEffect {   Id = Guid.Parse("") };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
