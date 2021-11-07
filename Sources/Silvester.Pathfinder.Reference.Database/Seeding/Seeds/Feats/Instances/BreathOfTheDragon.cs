using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("7c63d84e-ccb8-42b6-81da-35e9ad0cac34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Breath of the Dragon",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8792b9a3-fb28-4468-bb86-2a7e3e5e9e54"), Type = TextBlockType.Text, Text = "You can use a powerful breath weapon, much like the dragon you emulate. You gain the (spell: dragon breath) sorcerer bloodline spell and a focus pool of 1 Focus Point. If you already have a focus pool, increase your number of Focus Points by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("496cf9df-a01f-4582-9a7f-bd26c3fcd5a6"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bc18d3d-7a91-484b-b320-606882245af2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
