using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LarcenousTail : Template
    {
        public static readonly Guid ID = Guid.Parse("b7a52e0c-5054-48c4-ac89-dd99ec2b623d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Larcenous Tail",
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
            yield return new TextBlock { Id = Guid.Parse("43181459-a6f3-46cb-aa6c-9c1949cd163e"), Type = TextBlockType.Text, Text = "Your tail’s chaotic and independent nature causes it to perform mischief even when you don’t intend it, and it can somehow steal things it shouldn’t be able to handle. You can use your tail to (action: Steal) an object, though your tail still can’t hold onto it at the end of your action. If you have a hand free, you can transfer the stolen object to your hand. Otherwise, your tail surreptitiously drops it on the ground in your space, where you can grab it later. Observers other than your target who haven’t witnessed you stealing something with your tail are usually distracted, meaning the GM will usually decrease their Perception DCs, as normal for (action: Stealing | Steal) something." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69fd34ba-46e9-497d-8811-7f5056f10def"), Feats.Instances.SkillfulTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7b14fe3-deae-497a-b43e-21c5265c484c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
