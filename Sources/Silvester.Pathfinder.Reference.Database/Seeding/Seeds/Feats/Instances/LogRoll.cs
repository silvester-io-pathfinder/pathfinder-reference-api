using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LogRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("7e00c352-c9ea-4575-8583-ac6ec9638926");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Log Roll",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c686e5c-3721-4c4a-adfd-4f1f6d640ee6"), Type = TextBlockType.Text, Text = "You shuffle your feet to dislodge the surface beneath you or otherwise cause your opponent to become unsteady. Attempt an Acrobatics check against the adjacent creature’s Reflex saving throw DC. On a success, the creature falls. On a critical failure, you fall." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("52fe87ec-a100-4f5d-87ab-bdd0417647c4"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08d24e1f-37ee-487a-89b9-c36aed4450ba"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
