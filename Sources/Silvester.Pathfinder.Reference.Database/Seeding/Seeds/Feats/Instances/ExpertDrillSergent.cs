using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertDrillSergent : Template
    {
        public static readonly Guid ID = Guid.Parse("b41bd83a-114f-4cd3-b477-be62c79f4cf8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Drill Sergent",
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
            yield return new TextBlock { Id = Guid.Parse("743ef4e3-2d0b-4967-81d3-26e7d81bea74"), Type = TextBlockType.Text, Text = "You know how to get the most out of your allies. While exploring, when you are leading and allies are (Action: Following the Expert | Follow the Expert), you grant a +3 circumstance bonus instead of +2 if you’re an expert in the applicable skill, and a +4 circumstance bonus if you’re a master." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17e8f513-7b81-4367-a3a3-2eeea1582796"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
