using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbelievableLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("efe6ddd3-8570-4b48-b993-77baf8bc56e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbelievable Luck",
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
            yield return new TextBlock { Id = Guid.Parse("b3f513d1-338a-4a84-b1cc-19b9aeae967d"), Type = TextBlockType.Text, Text = "While no one, not even you, might appear to understand why, you demonstrate a greater ability to hit your targets regardless of the obstacles in your way. You can use the (feat: Accidental Shot) activity granted to you by the Unexpected Sharpshooter Dedication once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f262d01-1642-4837-b9c3-ea322e226bf2"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ae2fb27-5f6e-4808-aead-c5eca8f14c33"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
