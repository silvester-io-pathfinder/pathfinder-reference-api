using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainScribeMobility : Template
    {
        public static readonly Guid ID = Guid.Parse("99da2da6-fc04-4464-91e9-faf264bb87f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain-Scribe Mobility",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25f70b63-c7bf-4f44-a017-8fb79764ab9c"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of Rain-Scribe magic and (action: Stride) twice; difficult terrain does not reduce your Speed, even if the difficult terrain has been manipulated by magic. Your magic clears the difficult terrain in each square you entered; until your next turn, those squares aren’t difficult terrain for any creature walking through them (or are normal difficult terrain if they were previously greater difficult terrain)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("02b6a1db-781e-4955-818f-0a2f4e68068b"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("582c7bc3-bf6e-48e5-8148-9a4c75598812"), "Rain-Scribes affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("189e64ab-e88e-4b37-b259-d483dee79e63"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
