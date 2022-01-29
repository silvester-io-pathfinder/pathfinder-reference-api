using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WingThrash : Template
    {
        public static readonly Guid ID = Guid.Parse("0f32e188-fc52-41ef-bd53-562842798123");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wing Thrash",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00e203ee-e4da-4c70-9770-0f49cf3ffefa"), Type = TextBlockType.Text, Text = $"The bat thrashes wildly with its wings, making wing {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against up to three adjacent foes. Each attack counts toward the bat's multiple attack penalty, but the penalty only increases after all the attacks have been made." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54e68f05-7de8-401f-834e-5fdbef0ccf8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
