using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("aa56a592-7f69-4042-ba57-a71c3bb6ee12");

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
            yield return new TextBlock { Id = Guid.Parse("d57f4876-4512-4a63-8030-881a26d69328"), Type = TextBlockType.Text, Text = "You shroud yourself in smoke, making it harder for your foe to hit you. If you’re concealed, the DC of the flat check increases from 5 to 7; if you’re hidden, it increases from 11 to 13." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3577eff6-794c-4201-ac41-4d2c30b622ae"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
