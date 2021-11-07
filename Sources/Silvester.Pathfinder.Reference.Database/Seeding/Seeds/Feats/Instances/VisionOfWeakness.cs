using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VisionOfWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("78d7b221-34ea-47f5-98f5-32e7797a1b8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vision of Weakness",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2dcde2f2-7cc6-4613-a879-d6aae05a48de"), Type = TextBlockType.Text, Text = "You can call upon divine insights to single out your foes’ weak points. You learn the (spell: vision of weakness) revelation spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61799d7d-ca56-4716-91cc-d344f1a8d273"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
