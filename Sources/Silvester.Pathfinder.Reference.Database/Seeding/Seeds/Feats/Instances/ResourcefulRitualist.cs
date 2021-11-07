using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResourcefulRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("a5727469-7356-4a35-99bf-74deaff05256");

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
            yield return new TextBlock { Id = Guid.Parse("b8736861-0890-48ec-9ab5-d4e384fa8064"), Type = TextBlockType.Text, Text = "You can cast difficult rituals that might otherwise be just beyond your skill. You can attempt checks to cast a ritual that requires expert proficiency if you are trained, master proficiency if you are an expert, or legendary proficiency if you are a master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ce3309b-3310-4080-82e7-7b6513aed221"), Feats.Instances.RitualistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92d65c01-705a-4526-9790-2719a3625c2d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
