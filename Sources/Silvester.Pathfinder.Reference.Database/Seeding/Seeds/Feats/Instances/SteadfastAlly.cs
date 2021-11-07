using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadfastAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("e1cdfadb-1e90-43ce-a20c-c07de8ca4670");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steadfast Ally",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12bca14a-b6bb-4066-a4fe-1f66377b8718"), Type = TextBlockType.Text, Text = "Your presence alone is enough to provide your allies with emotional support. You can use the (Action: Aid) reaction to grant a bonus to another creature’s Will saving throw even when you haven’t prepared to help." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("67ce0a46-2e80-44ce-95a6-ec4407d1faf9"), Feats.Instances.LoyalEmpath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a97a31a-6104-47fd-bdde-18449a03809b"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
