using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChannelTheGodmind : Template
    {
        public static readonly Guid ID = Guid.Parse("7b5e34b4-e59a-4a83-a159-2d808cb46505");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channel the Godmind",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3c22feb-fa3a-4309-8618-bc9cdbc42d76"), Type = TextBlockType.Text, Text = $"You tap into the Godmind's collective cognitive well, rapidly parsing near-infinite variables to read your surroundings. For 1 minute, you gain precise motion sense out to 60 feet, you can see invisible creatures and objects, and you gain the effects of a 9th-level {ToMarkdownLink<Models.Entities.Spell>("true seeing", Spells.Instances.TrueSeeing.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ad97348-b6cc-4e62-8785-d64af79fc06e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
