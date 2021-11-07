using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EagleEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("968d495c-45ad-4abe-bd37-b9048a4ac21b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eagle Eyes",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae310ac6-a800-46dd-bf7c-55e1df67c96b"), Type = TextBlockType.Text, Text = "You and your spotter are adept at watching out for one another. As long as you can see or hear each other, neither of you is flat-footed to hidden, undetected, or flanking creatures of your level or lower, or to creatures of your level or lower using a surprise attack. However, they can still help their allies flank." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6aa519f3-3b8d-4263-a369-6b490a9f4840"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1098b7b6-c52e-423e-ac91-287feeda2dbd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
