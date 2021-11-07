using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurpriseStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3ac7c08c-a7a0-4b8f-a566-0bfbe27318f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surprise Strike",
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
            yield return new TextBlock { Id = Guid.Parse("155cdb56-918b-454d-8f38-f1348e6ad502"), Type = TextBlockType.Text, Text = "Whenever you make a (action: Strike) with an improvised weapon against a creature that hasn’t seen you make a (action: Strike) using an improvised weapon or that is otherwise ignorant of your skill with improvised weapons, the creature is flat-footed against you for that (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("328cb639-d301-43b8-a4f1-4e4aa1cd524e"), Feats.Instances.WeaponImproviserDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9427cea5-53a8-4df9-96e6-74bb463106e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
