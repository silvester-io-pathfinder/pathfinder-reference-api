using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainScribeSustenance : Template
    {
        public static readonly Guid ID = Guid.Parse("c2ab906c-af4c-40a3-9a85-f8e367fbd638");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain-Scribe Sustenance",
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
            yield return new TextBlock { Id = Guid.Parse("9edddd57-966f-419f-b21f-78ceddcbd5bd"), Type = TextBlockType.Text, Text = "You use the power of your Rain-Scribe magic to draw on a stream of primal power for sustenance. You don’t need to eat or drink and need only 6 hours of rest to feel well rested. You must still rest at least 8 hours and spend 1 hour of preparation to regain resources usable only a limited number of times per day, such as spell slots." };
            yield return new TextBlock { Id = Guid.Parse("7df50754-55d0-4387-a430-af6ec29081eb"), Type = TextBlockType.Text, Text = "You can draw on primal power to stay awake and alert while otherwise resting your body and mind, gaining the full benefits of an 8-hour rest without falling asleep. When you do, you lose the other benefits of Rain-Scribe Sustenance for 1 week while your primal energies recharge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40652635-089b-47d9-aede-1a81fa5572d6"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("f68ab136-ff3c-4c22-990b-ae7af0597ab6"), "Rain-Scribes affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f513467-4eb5-42ea-8f36-ea2b0822a749"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
