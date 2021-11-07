using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GruesomeStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("6542753e-975c-49d5-b573-50977ea8b95c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gruesome Strike",
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
            yield return new TextBlock { Id = Guid.Parse("c51cc355-2eeb-4a9d-a25f-93eeedaad142"), Type = TextBlockType.Text, Text = "Make a (action: Strike) against the creature that triggered your champion’s reaction. If you hit, the target takes double the extra damage from your reaction and must succeed at a Fortitude save against your class DC or be drained 1. Regardless of the result, the creature is temporarily immune to your Gruesome Strike for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("5d679185-021e-42cc-84c1-ec9150435e56"), Tenets.Instances.Evil.ID);
            builder.Manual(Guid.Parse("cd7ddd9c-fb23-4a17-8839-b1328e2d14cc"), "Champion's reaction that grants extra damage with your Strikes");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16e55949-95dd-446a-b5a3-b65d9a669cbc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
