using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoonyLore : Template
    {
        public static readonly Guid ID = Guid.Parse("57ade1a0-acbf-4619-b0cc-26f07c12d3af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoony Lore",
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
            yield return new TextBlock { Id = Guid.Parse("ea4a464d-af4d-4d2a-9956-1468cccdc3ee"), Type = TextBlockType.Text, Text = "Growing up in shoony society, you learned the value of honesty, friendship, and hard work, even during trying times. You gain the trained proficiency rank in Diplomacy and Survival. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Shoony Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afaeb35b-59c1-4aa3-85fa-ad33e8e42043"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
