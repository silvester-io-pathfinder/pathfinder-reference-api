using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstantGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("be4077d5-9773-414f-8c86-942251edc9a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Constant Gaze",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc4fc26d-0196-4d40-9e94-2d0677c96ae5"), Type = TextBlockType.Text, Text = "Your eyes keep a continual watch for dangers from all sides. You can’t be flanked by creatures of your level or lower, even when you haven’t used (feat: Watchful Gaze)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("250e678c-50ac-453e-a13a-798bb03402af"), Feats.Instances.WatchfulGaze.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("788315c9-d63d-4c8f-91fa-3f0caf6f3a78"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
