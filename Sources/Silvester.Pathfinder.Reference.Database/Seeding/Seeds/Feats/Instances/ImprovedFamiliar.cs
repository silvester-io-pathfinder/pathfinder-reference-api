using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("0aec6871-d01a-4035-b779-8eaa2847b307");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("771e383d-8b05-47e6-964b-27fad177d4d0"), Type = TextBlockType.Text, Text = "You find it easy to attract a powerful and unusual familiar to your side. The number of abilities required to make your familiar a specific familiar is two lower than normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a69f43f6-e894-474a-a955-badaaa7d7a13"), Feats.Instances.FamiliarMasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a41b9d23-aad9-4b6a-a17b-759f157bb925"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
