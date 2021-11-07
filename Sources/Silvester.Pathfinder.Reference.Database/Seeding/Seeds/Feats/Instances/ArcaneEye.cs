using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneEye : Template
    {
        public static readonly Guid ID = Guid.Parse("8a902f5d-82a4-44a8-b236-d654e020f329");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Eye",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df036063-6f13-4d73-ace1-7dcdef3ede5d"), Type = TextBlockType.Text, Text = "Your eye has been magically enhanced to pierce darkness. You gain darkvision." };
            yield return new TextBlock { Id = Guid.Parse("07b46ab4-3641-482d-9d12-6df518876628"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("b197320c-9d9d-4066-9446-814e2a96eeb8"), Type = TextBlockType.Text, Text = "~ Enhancement: Your eye can see invisible creatures in brief spurts. You can cast (spell: see invisibility) as an arcane innate spell once per hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("0d58e016-3a3d-48a4-b37b-c638a84c6cbf"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c32b3f0-c7ac-4023-a7c5-40d4be916367"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
