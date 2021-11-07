using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BigMouth : Template
    {
        public static readonly Guid ID = Guid.Parse("83e53d18-628b-446e-8307-ffe9f1a902dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Big Mouth",
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
            yield return new TextBlock { Id = Guid.Parse("4bfc5fd1-7588-4ea2-9114-9008ce3944e3"), Type = TextBlockType.Text, Text = "Your cheek pouches are especially stretchy. Instead of storing up to four items of Light Bulk in your cheek pouches, you can store up to 1 Bulk worth of items. The maximum size of a given item is unchanged." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe510b83-f487-48d7-8c8f-a8442eb58c0b"), Feats.Instances.CheekPouches.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa1e6aea-1091-45f7-bbe2-f682ee1557ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
