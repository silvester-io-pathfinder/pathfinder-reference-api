using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClearTheWay : Template
    {
        public static readonly Guid ID = Guid.Parse("67080d47-11f1-4f7b-a395-de8f6529c847");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clear the Way",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf288f19-cef8-4d03-a7b6-de497a2e31d6"), Type = TextBlockType.Text, Text = "You put your body behind your massive weapon and swing, shoving enemies to clear a wide path. You attempt to (action: Shove) up to five creatures adjacent to you, rolling a separate Athletics check for each target. Then (action: Stride) up to half your Speed. This movement doesn't trigger reactions from any of the creatures you successfully (action: Shoved | Shove)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5d905ad4-eefa-4c4c-96be-6c59f9aad182"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a195738a-394f-4f5b-a868-fdda0e882d39"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
