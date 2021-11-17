using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("6ee26bda-7363-4e7f-a2d0-2ac69a226ad3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Shadow",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1f40184-3cbd-4b5c-ae4c-dec3759385b7"), Type = TextBlockType.Text, Text = "~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("135bdc20-293f-4d2a-a434-de14d6f35a0d"), Type = TextBlockType.Text, Text = "You gain the (spell: malicious shadow) hex, and your familiar learns (spell: chilling darkness)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("152f85a8-8155-40c2-9458-6b41760ee18d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
