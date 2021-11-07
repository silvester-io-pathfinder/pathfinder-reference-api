using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicBloodPotency : Template
    {
        public static readonly Guid ID = Guid.Parse("1caf2647-0c98-44fd-b225-fc7eb092cfdb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Blood Potency",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1dac5dc5-a731-4707-bdbe-d08f55265d43"), Type = TextBlockType.Text, Text = "You gain a 1st- or 2nd-level sorcerer feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41663571-62c7-4377-be96-b08e264a69a9"), Feats.Instances.SorcererDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("764ecf57-ee64-4503-9ad8-203029aee8ac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
