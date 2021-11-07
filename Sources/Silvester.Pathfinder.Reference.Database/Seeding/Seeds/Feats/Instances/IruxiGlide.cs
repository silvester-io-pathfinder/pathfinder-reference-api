using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IruxiGlide : Template
    {
        public static readonly Guid ID = Guid.Parse("bf2acec9-bf9c-4e81-9fb3-dab6d806cd0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iruxi Glide",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0e807a3-0615-4243-a212-f2c4bcd2fb90"), Type = TextBlockType.Text, Text = "You glide slowly toward the ground, 5 feet down and up to 25 feet forward through the air. As long as you spend at least 1 action gliding each round and haven’t yet reached the ground, you remain in the air at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("d2b2a23a-3839-4750-a758-93fb9c08f15a"), Heritages.Instances.CloudleaperLizardfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bc8f22b-7006-4e9d-ada2-b0412d48b96d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
