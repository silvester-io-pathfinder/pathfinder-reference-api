using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainScribeSustenance : Template
    {
        public static readonly Guid ID = Guid.Parse("b4ea6ed0-fdc7-4ffd-a55a-f2cd17a1e323");

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
            yield return new TextBlock { Id = Guid.Parse("9c1d4b37-5a8b-4792-be21-ed6e012ada5e"), Type = TextBlockType.Text, Text = $"You use the power of your Rain-Scribe magic to draw on a stream of primal power for sustenance. You don't need to eat or drink and need only 6 hours of rest to feel well rested. You must still rest at least 8 hours and spend 1 hour of preparation to regain resources usable only a limited number of times per day, such as spell slots." };
            yield return new TextBlock { Id = Guid.Parse("15dde4c4-e524-4cb5-a801-1646d639c6d1"), Type = TextBlockType.Text, Text = $"You can draw on primal power to stay awake and alert while otherwise resting your body and mind, gaining the full benefits of an 8-hour rest without falling asleep. When you do, you lose the other benefits of Rain-Scribe Sustenance for 1 week while your primal energies recharge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae4c4463-8318-4db1-893b-df667c3c74e0"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("f0d132f0-276a-437c-ab55-eeaaff4b463d"), "Rain-Scribes affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb3a1900-f0bf-4084-a729-8e0d4be01369"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
