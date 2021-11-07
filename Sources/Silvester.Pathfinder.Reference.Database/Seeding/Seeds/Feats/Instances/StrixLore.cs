using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrixLore : Template
    {
        public static readonly Guid ID = Guid.Parse("cf0210c8-0403-4246-8c78-25e5d36837d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strix Lore",
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
            yield return new TextBlock { Id = Guid.Parse("58f794bf-7c14-4d3c-a375-57720482282c"), Type = TextBlockType.Text, Text = "You’re well connected to your tribe and perhaps even strix communities beyond your own, where you’ve learned about the land and techniques of graceful movement. You gain the trained proficiency rank in Acrobatics and Nature. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Strix Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89413368-b511-44c2-b875-b45d9af06250"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
