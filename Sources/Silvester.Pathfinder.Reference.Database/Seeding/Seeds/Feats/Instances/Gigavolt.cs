using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gigavolt : Template
    {
        public static readonly Guid ID = Guid.Parse("353203af-70a3-410d-8b4b-cbaeebfc75fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gigavolt",
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
            yield return new TextBlock { Id = Guid.Parse("10bfff68-7a45-4f93-a4c2-70c62a49aac2"), Type = TextBlockType.Text, Text = "When you unleash electricity from your innovation, you can bounce it off obstacles, creating a field of electric death. When you use (feat: Megavolt), each time your line of electricity hits a solid barrier, such as a wall, it bounces off at an angle of your choice and continues until you have reached the full length of the line. Even if a creature is in the area from multiple bounces, it takes the damage only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e702c296-15d5-43c7-b95b-a43d302b6624"), Feats.Instances.Megavolt.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5427ee20-b55e-4c73-97d9-4bc2be432ed4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
