using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedFlair : Template
    {
        public static readonly Guid ID = Guid.Parse("8fd3d23b-e5e0-4ab4-86ab-4a147904d3cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Flair",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you select it, you gain another swashbuckler feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01efd736-fa30-46b3-a0a7-e4af365836e7"), Type = TextBlockType.Text, Text = "You gain one swashbuckler feat. For the purpose of meeting its prerequisites, your swashbuckler level is equal to half your character level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7eb168c0-7536-4011-8af0-5ff37df9c71c"), Feats.Instances.BasicFlair.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45c8c9ac-4a28-4730-aa13-7a5df37c5012"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
