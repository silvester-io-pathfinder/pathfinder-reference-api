using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersVision : Template
    {
        public static readonly Guid ID = Guid.Parse("9034bb2d-4b96-4987-a48f-313604ba3974");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunter's Vision",
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
            yield return new TextBlock { Id = Guid.Parse("58a41a35-9209-44a5-a38a-da7cdd7a2af9"), Type = TextBlockType.Text, Text = "You are so focused on your hunted prey that you can see it clearly even beyond the limits of your senses. You gain the (spell: hunter’s vision) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("0ce68f77-9800-4a2d-9e88-f538576f5a59"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3f25a3-186f-433b-b3c0-d9d707f82352"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
