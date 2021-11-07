using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AllysShelter : Template
    {
        public static readonly Guid ID = Guid.Parse("2c0f43f6-2677-4de6-8f7a-9607859cfa7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ally's Shelter",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw while adjacent to one or more allies, but you haven't rolled yet.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15d3be70-e7e6-415b-b280-b068c5379489"), Type = TextBlockType.Text, Text = "In stressful circumstances, you find strength in your allies&#39; example. Roll the save using an adjacent ally&#39;s modifier for that type of saving throw instead of your own." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9873f86-fd68-410b-889a-e5ea92967747"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
