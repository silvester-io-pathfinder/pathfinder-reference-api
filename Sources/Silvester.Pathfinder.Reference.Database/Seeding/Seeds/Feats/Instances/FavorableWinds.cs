using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavorableWinds : Template
    {
        public static readonly Guid ID = Guid.Parse("758e106a-ade2-4f9e-a233-418497d2cef9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favorable Winds",
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
            yield return new TextBlock { Id = Guid.Parse("b345ee0a-477c-445e-a1b7-01fdd08994b6"), Type = TextBlockType.Text, Text = "You wrap a shell of favorable wind around a weapon you wield. On your next (action: Strike) with a ranged weapon before the start of your next turn, you don’t take circumstance penalties on the attack roll due to wind. In addition, if that weapon has a range increment of 10 feet or less, increase its range increment by 10 feet for that (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d7b79e5f-a4e4-47d5-8819-dd18f0d9d740"), Feats.Instances.VirgaMay.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aea4b426-7cf5-4544-af8a-5eaddcb2e733"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
