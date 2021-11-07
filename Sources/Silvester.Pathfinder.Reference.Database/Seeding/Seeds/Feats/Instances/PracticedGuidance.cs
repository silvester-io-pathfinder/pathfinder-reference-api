using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PracticedGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("f18a65bb-66e9-4189-be9b-0af89fb7503a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Practiced Guidance",
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
            yield return new TextBlock { Id = Guid.Parse("4903f752-c691-4d55-9b2f-ca96044206c9"), Type = TextBlockType.Text, Text = "Making one’s way to safety can be harrowing, but you have extensive practice at helping others along that path. When you roll a success to (action: Aid) a member of your crop, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9807bfb0-a229-4ad1-b84e-2c17ea3fa11e"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9a69f84-0c7b-4f58-8d60-a0c734b25777"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
