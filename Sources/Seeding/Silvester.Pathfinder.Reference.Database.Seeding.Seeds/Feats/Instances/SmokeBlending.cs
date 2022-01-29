using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("db8fa002-0bea-4534-b03e-1879d862f269");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smoke Blending",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature attempts a flat check to target you because you're concealed or hidden due to fog, haze, mist, or smoke.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80394af7-4a07-4878-b3e5-46f0e9e5bef4"), Type = TextBlockType.Text, Text = $"You shroud yourself in smoke, making it harder for your foe to hit you. If you're concealed, the DC of the flat check increases from 5 to 7; if you're hidden, it increases from 11 to 13." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a772215a-93be-43e8-b2e8-70ea149e7630"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
