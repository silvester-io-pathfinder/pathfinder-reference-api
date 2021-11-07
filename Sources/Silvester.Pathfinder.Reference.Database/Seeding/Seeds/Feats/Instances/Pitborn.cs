using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pitborn : Template
    {
        public static readonly Guid ID = Guid.Parse("bf3b8c49-4654-4ad3-a75e-4931ff5d1acf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pitborn",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3ca8963-da3f-4487-bca0-8bab5873559e"), Type = TextBlockType.Text, Text = "Your blood bears the mark of a demon, a living embodiment of sin from the fetid depths of the Abyss. Demonic power pulses through your veins and manifests in a different way for each pitborn, whether you have webbed fingers and thrive in the water, large hands capable of wrestling larger foes, or some other manifestation. You are trained in Athletics. If you were already trained in Athletics (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("f1ddc73a-d081-4697-bda7-c446b596fab1"), Type = TextBlockType.Text, Text = "You also gain any one common 1st-level skill feat with a prerequisite of trained in Athletics, as reflects the manifestation of your Abyssal blood." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1c3f13-7cda-4288-a023-d90483de6789"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
