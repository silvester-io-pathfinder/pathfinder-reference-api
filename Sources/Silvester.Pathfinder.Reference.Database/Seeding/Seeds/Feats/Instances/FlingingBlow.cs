using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlingingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("64872a59-a7a2-4dac-aa8b-954de6a12d8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flinging Blow",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b98db0a5-c9d5-44c6-8731-633649d0b406"), Type = TextBlockType.Text, Text = "You take a moment to center yourself, then unleash a powerful blow that sends your target tumbling away. Make an unarmed (action: Strike). If you hit, the target must succeed at a Fortitude save against your class DC or be pushed up to 10 feet directly away from you (or 20 feet, on a critical failure) and fall prone. If another creature or physical object would prevent this movement, both your target and the blocking creature or object take 1d6 bludgeoning damage per 5 feet of movement that was prevented." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d988fdce-075f-469a-ba4a-080b706b9c57"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
