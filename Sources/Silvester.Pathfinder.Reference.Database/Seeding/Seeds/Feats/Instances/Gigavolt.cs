using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gigavolt : Template
    {
        public static readonly Guid ID = Guid.Parse("9eb32c6e-be27-4b3f-8441-b102bc6078b8");

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
            yield return new TextBlock { Id = Guid.Parse("3f2b2e4a-6193-4975-83bb-67cb16b23a60"), Type = TextBlockType.Text, Text = "When you unleash electricity from your innovation, you can bounce it off obstacles, creating a field of electric death. When you use (feat: Megavolt), each time your line of electricity hits a solid barrier, such as a wall, it bounces off at an angle of your choice and continues until you have reached the full length of the line. Even if a creature is in the area from multiple bounces, it takes the damage only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("75b4439b-2cfd-4673-b2df-7b197cfebe86"), Feats.Instances.Megavolt.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b259150e-3915-4140-be5c-f025df6d833c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
