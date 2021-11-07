using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StaffSweep : Template
    {
        public static readonly Guid ID = Guid.Parse("0590ff3a-f977-415f-8d98-0f1cf3a3c995");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Staff Sweep",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a16b2d4a-44bd-440d-b022-0fb765b8cdf3"), Type = TextBlockType.Text, Text = "You sweep your foes away with your staff. Roll an Athletics check to (action: Shove) or (action: Trip), and compare the result to the appropriate DCs of up to two foes, each of whom must be within your reach and no more than 5 feet apart." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2114c6f7-6679-48d7-be7c-cfdf3e32818d"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43bf4324-78e8-49c9-bbbe-a6c0e05f1958"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
