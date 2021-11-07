using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallYourShot : Template
    {
        public static readonly Guid ID = Guid.Parse("bc9752c3-0e6f-4418-9846-b4754e2bf649");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Your Shot",
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
            yield return new TextBlock { Id = Guid.Parse("4b5c341a-9a1f-4a7f-8be4-f58a9c814e5d"), Type = TextBlockType.Text, Text = "When you successfully (feat: Play to the Crowd), add the following to the list of benefits you can choose from:" };
            yield return new TextBlock { Id = Guid.Parse("4d9ce6eb-5cab-4abe-9413-c5d514227d22"), Type = TextBlockType.Enumeration, Text = " : Choose a creature within 30 feet that can see you to become frightened 1. This effect has the (trait: emotion), (trait: fear), (trait: mental), and (trait: visual) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7fa0f1ce-a571-42dc-aae5-6bb4bf2bde8b"), Feats.Instances.PlayToTheCrowd.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("386ed51e-965a-46e2-ad65-3fe6585cfc7f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
