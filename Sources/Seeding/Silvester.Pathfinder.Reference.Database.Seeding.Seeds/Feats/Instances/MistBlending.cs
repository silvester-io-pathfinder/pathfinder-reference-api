using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MistBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("4831975f-5609-40af-a76f-7cc69fcdc220");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mist Blending",
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
            yield return new TextBlock { Id = Guid.Parse("23a9abd3-9f6e-4aaf-926d-1e1df935f866"), Type = TextBlockType.Text, Text = "You shroud yourself in mist, making it harder for your foe to hit you. If you're concealed, the DC of the flat check increases from 5 to 7; if you're hidden, it increases from 11 to 13." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e1999eb-8ff6-4e47-bf40-f9d8379880a1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
