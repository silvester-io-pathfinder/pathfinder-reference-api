using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnnervingProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("5196e694-9146-4ed0-b206-4b9eda826bb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unnerving Prowess",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically succeed at a Strike or Disarm with your Aldori dueling sword.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e839aa0-f6e9-4449-b354-5b288eb98a64"), Type = TextBlockType.Text, Text = "Your incredible skill with your blade unnerves your foes. You attempt to (action: Demoralize) the target of your (action: Strike) or (action: Disarm). This (action: Demoralize) attempt does not have the (trait: auditory) trait, nor do you take a penalty to the check if the target doesn’t understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e4ec6934-b0af-4de8-a947-1691cfeff650"), Feats.Instances.AldoriDuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccc3bab8-8e9b-42fb-96b2-40bd7da479a9"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
