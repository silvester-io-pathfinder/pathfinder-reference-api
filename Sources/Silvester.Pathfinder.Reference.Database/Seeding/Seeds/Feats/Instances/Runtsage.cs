using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Runtsage : Template
    {
        public static readonly Guid ID = Guid.Parse("ff54ab7f-0e73-4b6c-9f54-17f1bb5d80e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runtsage",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85fe710a-1b55-4a85-a79d-f20b3505a60f"), Type = TextBlockType.Text, Text = "Unlike most of your kind, who dismiss goblins as embarrassments or expendable annoyances, you have studied the methodology behind their irresponsible and incomprehensible actions. You gain the (feat: Adopted Ancestry) general feat and must select goblin as the feat’s chosen ancestry. You also gain one 1st-level goblin ancestry feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21586b59-3986-430b-b8f0-8ef158e455fd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
