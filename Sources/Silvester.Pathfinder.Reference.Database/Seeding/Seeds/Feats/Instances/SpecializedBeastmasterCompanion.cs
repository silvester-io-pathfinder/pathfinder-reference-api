using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpecializedBeastmasterCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("83353886-1ebe-4f91-8e3b-811a06d05ac2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Specialized Beastmaster Companion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time, add a different specialization to your nimble and savage companions. Your nimble and savage companions can have up to three specializations each.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6afdbf3d-5f29-456f-b157-dc05b030f518"), Type = TextBlockType.Text, Text = "Your nimble and savage animal companions become cunning enough to become specialized. Each companion gains one specialization of your choice (page 217, choose separately)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5fa5c52d-b1da-4cb8-98f2-8a1c3f523d7f"), Feats.Instances.IncredibleBeastasterCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91ed034a-e9f9-4f3e-ae32-5517266aa9de"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
