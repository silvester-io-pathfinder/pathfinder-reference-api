using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResourcefulRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("4ac51c52-c6b0-4417-bdab-f0d3fc2de969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resourceful Ritualist",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc123ac1-032f-4c8e-958e-42807bc6feda"), Type = TextBlockType.Text, Text = "You can cast difficult rituals that might otherwise be just beyond your skill. You can attempt checks to cast a ritual that requires expert proficiency if you are trained, master proficiency if you are an expert, or legendary proficiency if you are a master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f10759a5-daf8-4179-b9dd-3ecac533269f"), Feats.Instances.RitualistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81d06163-9171-4c74-a8c8-ee4bf54ee07c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
