using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CompanionsCry : Template
    {
        public static readonly Guid ID = Guid.Parse("a46b3fde-607c-4d80-bed1-18d03534f0df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Companion's Cry",
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
            yield return new TextBlock { Id = Guid.Parse("7e05e31d-1b38-422a-a6e3-8374efaa5be9"), Type = TextBlockType.Text, Text = "You can urge your companion to do its utmost. You can spend 2 actions to (action: Command an Animal) instead of 1 when commanding your animal companion. If you do, your animal companion uses an additional action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("465a0bf8-50b6-4a57-a8c9-f9447f34826e"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa00b266-3f42-4e50-8286-ce1c5909c958"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
