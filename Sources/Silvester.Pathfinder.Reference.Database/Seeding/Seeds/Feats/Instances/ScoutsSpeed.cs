using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScoutsSpeed : Template
    {
        public static readonly Guid ID = Guid.Parse("9c81d15f-2a2c-4a17-a892-afaed9bf746c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Speed",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fb0f526-c3e1-42e3-9b44-aaeb8025d44f"), Type = TextBlockType.Text, Text = "You move faster, especially when traveling, allowing you to scout ahead and report back without slowing your allies. You gain a +10-foot status bonus to your Speed. When calculating your travel speed, this increases to a +20-foot status bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f9f1792-d0e3-4733-b8fb-391b14fc172b"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78cc1c2a-a120-4492-9c53-045d67548689"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
