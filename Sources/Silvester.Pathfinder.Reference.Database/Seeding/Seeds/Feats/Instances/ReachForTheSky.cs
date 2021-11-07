using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReachForTheSky : Template
    {
        public static readonly Guid ID = Guid.Parse("f787e003-b73f-45de-be1f-b1b4938d9486");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach for the Sky",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d240fa3f-055b-46e2-9a36-28b4966ca5e7"), Type = TextBlockType.Text, Text = "You command the room, firing a gun into the air and ordering everyone to surrender and put their hands in the air. You fire your firearm and then attempt a single Intimidation check to (action: Demoralize) each enemy within 30 feet. Creatures who become frightened instinctively put their hands in the air. If they had (action: Raised a Shield|Raise a Shield), they lose the benefits, as they raise the shield above their head where it’s of little use to block attacks. With their hands in the air, each of these frightened creatures can’t use reactions or free actions that require their hands, or items held in their hands, until the beginning of their next turn. Regardless of the result, each creature is then temporarily immune to Reach for the Sky for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ead82ce4-8cf6-47b1-a778-058be2164925"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("719c374f-c38f-409b-ade6-0c7d2269538d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
