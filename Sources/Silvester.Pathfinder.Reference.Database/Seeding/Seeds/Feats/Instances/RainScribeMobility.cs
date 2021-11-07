using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainScribeMobility : Template
    {
        public static readonly Guid ID = Guid.Parse("ef12ff58-43a5-46eb-b69a-7e3915b86d83");

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
            yield return new TextBlock { Id = Guid.Parse("568d1c81-eb95-442c-be5a-d63d7bf7befb"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of Rain-Scribe magic and (action: Stride) twice; difficult terrain does not reduce your Speed, even if the difficult terrain has been manipulated by magic. Your magic clears the difficult terrain in each square you entered; until your next turn, those squares aren’t difficult terrain for any creature walking through them (or are normal difficult terrain if they were previously greater difficult terrain)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc6da85d-5e5d-4588-9e9c-ce05560c17c8"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("ba32a580-2e56-4691-8ba3-ae57b798a7c2"), "Rain-Scribes affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d6ab7b2-994c-48a9-89f4-96a8ec4c644f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
