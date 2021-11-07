using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Idyllkin : Template
    {
        public static readonly Guid ID = Guid.Parse("6de214a2-9af1-4af5-a12e-4a6aae5d90a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Idyllkin",
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
            yield return new TextBlock { Id = Guid.Parse("816d3bf0-ddc6-4272-93f3-15be5c7a7d93"), Type = TextBlockType.Text, Text = "Your wild, unique features betray your agathion birthright. Serene celestials from the plane of Nirvana, agathions seek the peaceful path, ensuring a better world for all to coexist. Your halcyon demeanor leads you to search for peaceful resolution to conflict. You gain the trained proficiency rank in Nature. If you would automatically become trained in Nature (from your background or class, for example), you instead become trained in a skill of your choice. You know the (language: Sylvan) language and gain the (feat: Natural Medicine) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd7810f-7831-43e1-b76b-a75f4ac414b2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
