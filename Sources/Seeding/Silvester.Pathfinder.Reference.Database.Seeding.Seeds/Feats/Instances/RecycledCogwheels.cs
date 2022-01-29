using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecycledCogwheels : Template
    {
        public static readonly Guid ID = Guid.Parse("a02dbb0d-82ad-43ef-846a-2c5ae1da5997");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recycled Cogwheels",
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
            yield return new TextBlock { Id = Guid.Parse("aa052d8f-d9d3-46ac-a5bc-509f693b1869"), Type = TextBlockType.Text, Text = $"You're able to scavenge the cogwheels from your daily quick-deploy snares that use gears. This allows you to deconstruct a snare that didn't trigger in order to set the snare up somewhere else. Doing so takes the same number of actions as setting the snare did. When you do, you recover the snare and can deploy it in another location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60fbe28e-5194-493e-b71d-57a49c0f525d"), Feats.Instances.TrapsmithDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("921b6557-064f-4009-9cff-2659ae14f700"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
