using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParagonConstructCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("8971080f-bdc8-4ed3-9e8a-c670ad56a08e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paragon Construct Companion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("439946ab-f063-4a03-a890-073c6d165723"), Type = TextBlockType.Text, Text = $"Your construct companion has reached the pinnacle of form and function. Your construct companion becomes a paragon construct companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2a241cd8-c75d-4af8-8854-b087fdd9896a"), Feats.Instances.IncredibleCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea2d29e4-c317-4b0e-bc2c-471bc2899e48"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
