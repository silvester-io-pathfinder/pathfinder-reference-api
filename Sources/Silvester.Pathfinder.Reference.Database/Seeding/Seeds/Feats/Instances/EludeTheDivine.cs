using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EludeTheDivine : Template
    {
        public static readonly Guid ID = Guid.Parse("156f374a-b2fc-440b-972e-7c7209bad5c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elude the Divine",
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
            yield return new TextBlock { Id = Guid.Parse("c523f3a1-7be9-4040-96c3-5999f5738d14"), Type = TextBlockType.Text, Text = "You are able to escape inquisitions involving divine magic, allowing you to blend in well in Mzali but also to avoid unwanted attention in other oppressive theocracies. You gain the (feat: Slippery Secrets) skill feat, and its benefits also apply against (trait: divination) effects that attempt to discern your deity. When using (feat: Slippery Secrets) against a (trait: divine) (trait: divination), you gain a +2 circumstance bonus, and on a critical success, the divination reveals false information appropriate to your false persona, rather than nothing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3f9ae979-306c-4563-8872-d61ff7af41ac"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c65be60-46c5-47da-994e-cb612c44b3af"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
