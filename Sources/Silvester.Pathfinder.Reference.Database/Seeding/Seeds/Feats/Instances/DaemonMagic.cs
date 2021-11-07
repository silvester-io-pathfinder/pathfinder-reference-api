using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaemonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("d4ef7439-5011-4b29-a127-fb9a4fc3c1c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daemon Magic",
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
            yield return new TextBlock { Id = Guid.Parse("e91f6c21-8b67-4f07-9766-7b799f7dd673"), Type = TextBlockType.Text, Text = "The magic of Abaddon runs through your blood, and you can wield that power. You can cast (spell: death knell) and (spell: false life) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8a369291-dd7b-4c5e-a673-370eb97c7ee6"), Feats.Instances.Grimspawn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6877f26-1d24-4f7d-a5cb-3bf6af33f812"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
