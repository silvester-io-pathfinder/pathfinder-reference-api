using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnthrallingAllure : Template
    {
        public static readonly Guid ID = Guid.Parse("093502cc-357d-4c70-8809-a9a4f84b1568");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enthralling Allure",
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
            yield return new TextBlock { Id = Guid.Parse("c7d7852b-b679-4154-a413-6a0c4d73a2a1"), Type = TextBlockType.Text, Text = "The powers of domination employed by your progenitors have manifested in you as well. Once per day, you can cast (spell: charm) as a 1st-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b802bed-de8a-40c8-a181-24cd0ad55e16"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
