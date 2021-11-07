using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeftingShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("503a71e6-3c96-4a49-b09f-1c304808e491");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hefting Shadow",
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
            yield return new TextBlock { Id = Guid.Parse("60bea565-c099-4509-89af-189bf07f4798"), Type = TextBlockType.Text, Text = "Your shadow can contain objects. You can (action: Interact) with your shadow to store or retrieve objects, just like you would a mundane container (meaning you spend two (action: Interact) actions total to store and then retrieve the object, for example). Your shadow can contain 2 Bulk of objects, which don’t count toward the Bulk you’re carrying. The items remain solid but take on a shadowy patina while stored this way. Though the items are in your shadow and can be detected normally, you gain a +2 circumstance bonus to Stealth checks to (action: Conceal the Objects | Conceal an Object) unless someone knows to check your shadow for items." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("312ca5ac-1dd5-4ee6-af08-1539d9a05fb9"), Feats.Instances.Clevershadow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c16a05f6-9136-47ef-8bd7-0f18c57534dc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
