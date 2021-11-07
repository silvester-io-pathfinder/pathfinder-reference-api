using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleConstructCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("d315cc06-5bab-43a2-a328-380499b09499");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Construct Companion",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d78ef63f-f73f-427e-959a-581143781050"), Type = TextBlockType.Text, Text = "Thanks to your continual tinkering, your construct companion has advanced to an astounding new stage of engineering, enhancing all its attributes. Your construct companion becomes an incredible construct companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("64ba78bd-77c3-4b44-b02b-2c3d7402c298"), Feats.Instances.AdvancedConstructCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76233955-5d8b-4b51-88eb-f62d4464d41e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
