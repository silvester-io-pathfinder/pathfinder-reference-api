using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangedDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("b97f8553-0625-4ce1-88dc-f5ea9c63faee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranged Disarm",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f008f463-981d-428f-8c05-2b5383546272"), Type = TextBlockType.Text, Text = "When using a simple firearm, you can shoot objects right out of your enemy’s hands. Attempt to (action: Disarm) the target using a ranged attack roll with your simple firearm, instead of attempting an Athletics check against the target’s Reflex DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7b111689-12fc-4eb2-bd68-ca4316a1ad56"), Feats.Instances.BulletDancerDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("3d60d2a2-6808-4f89-86b1-7801b0f9b865"), Feats.Instances.TrickShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccf56553-925a-4be5-aac7-a6f4ef0f3f4f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
