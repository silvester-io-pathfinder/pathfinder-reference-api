using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoothingMist : Template
    {
        public static readonly Guid ID = Guid.Parse("9201ab62-4bc7-4d6c-b9f2-3555c3958a38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soothing Mist",
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
            yield return new TextBlock { Id = Guid.Parse("cd8821f4-8a8f-4b56-b76e-a2b71d55fb98"), Type = TextBlockType.Text, Text = "You have a connection to the healing properties of nature and can produce a magical mist to heal damage and stop burning or bleeding. You gain the (spell: soothing mist) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("7a66065c-f866-45ca-a366-6665f6737913"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c3150e2-dddc-4d31-8541-7ebfeec4c3af"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
