using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AllysShelter : Template
    {
        public static readonly Guid ID = Guid.Parse("e0fed497-9fbb-4e72-9460-67fc42e4b747");

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
            yield return new TextBlock { Id = Guid.Parse("73039314-e22b-49a6-9386-84e1af9ecede"), Type = TextBlockType.Text, Text = "In stressful circumstances, you find strength in your allies&#39; example. Roll the save using an adjacent ally&#39;s modifier for that type of saving throw instead of your own." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9736260-27ad-4816-b036-d110644ef5b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
