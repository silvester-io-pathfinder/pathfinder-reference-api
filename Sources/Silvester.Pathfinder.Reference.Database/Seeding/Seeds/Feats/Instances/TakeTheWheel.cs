using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TakeTheWheel : Template
    {
        public static readonly Guid ID = Guid.Parse("61785ec8-1ed0-4a88-bf9e-6632f48408e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Take the Wheel",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("967c5172-096c-46bb-9225-8102b38ce19f"), Type = TextBlockType.Text, Text = "Diving into a moving vehicle and seizing the controls is nothing new for you. You Board and Take Control of the adjacent vehicle." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bc429520-91bc-435a-85eb-56460d896a5e"), Feats.Instances.TrickDriverDedication.ID);
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("9ae6d9b0-fe13-40e9-89b0-fb69846c83f1"), Proficiencies.Instances.Expert.ID, Lores.Instances.Driving.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d1909c8-34e6-4850-860d-2330f17170cc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
