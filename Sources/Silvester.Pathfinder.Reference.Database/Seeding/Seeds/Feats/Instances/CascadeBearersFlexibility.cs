using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeBearersFlexibility : Template
    {
        public static readonly Guid ID = Guid.Parse("3530f617-b6ce-434c-a68e-dccee6bb3f80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascade Bearers Flexibility",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ca03fe7-ea4d-4c03-8015-5e4a52cea8e0"), Type = TextBlockType.Text, Text = "You call upon your Cascade Bearer training to help you adjust a spell for the current situation. Until the end of your turn, you gain a single (trait: metamagic) feat from the druid class or the wizard class that has a level requirement of no more than half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae8f5e62-4f01-4e04-9751-98628472a1ff"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("da8f9060-9c08-4dd9-9df5-f6b2fdcb5e94"), "Cascade Bearers affiliation.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5af8569f-af1c-4e17-81fd-dc4ce52291e2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
