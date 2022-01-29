using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pitborn : Template
    {
        public static readonly Guid ID = Guid.Parse("e1c02cc3-31b0-4280-b183-e5e17113645d");

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
            yield return new TextBlock { Id = Guid.Parse("412dc86f-9545-415f-b0fc-c428482a549b"), Type = TextBlockType.Text, Text = $"Your blood bears the mark of a demon, a living embodiment of sin from the fetid depths of the Abyss. Demonic power pulses through your veins and manifests in a different way for each pitborn, whether you have webbed fingers and thrive in the water, large hands capable of wrestling larger foes, or some other manifestation. You are trained in Athletics. If you were already trained in Athletics (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("2b30858a-74d8-4c0a-b6cc-47457344861e"), Type = TextBlockType.Text, Text = $"You also gain any one common 1st-level skill feat with a prerequisite of trained in Athletics, as reflects the manifestation of your Abyssal blood." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f203861-c4c3-47be-aa18-208042b08e18"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
