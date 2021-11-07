using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PracticedReloads : Template
    {
        public static readonly Guid ID = Guid.Parse("7b5f657e-6bdf-4afe-9efc-353243a5d3ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Practiced Reloads",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c44f2434-0360-4c1e-9f01-4167b08e24ed"), Type = TextBlockType.Text, Text = "You’ve mastered the reloading techniques and methods usually practiced by only the most dedicated firearm professionals. You gain the slinger’s reload for the way you selected with Gunslinger’s Dedication." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("31dcb6da-9885-405b-8234-bfe601b24b9b"), Feats.Instances.GunslingerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e66f5c3-0122-45ed-baaf-b1cffa994337"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
