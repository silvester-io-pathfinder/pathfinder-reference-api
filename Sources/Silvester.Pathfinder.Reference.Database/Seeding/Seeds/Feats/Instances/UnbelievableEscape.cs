using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbelievableEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("5d10c0a8-c526-40f2-b969-1cb0982fbe4b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbelievable Escape",
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
            yield return new TextBlock { Id = Guid.Parse("9e0dfb07-06b8-4a7e-a148-35cef89f8500"), Type = TextBlockType.Text, Text = "Your ability to narrowly evade danger defies all logic. You can use (feat: Lucky Escape) once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d9ee826-9b7b-4f2f-87a5-af78621d5810"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("445e6e17-c086-4058-8e7f-0427187040cc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
