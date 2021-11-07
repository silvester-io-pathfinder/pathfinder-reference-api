using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannySuction : Template
    {
        public static readonly Guid ID = Guid.Parse("73b9c8c8-766b-428c-aa68-b24bf1d25614");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Suction",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("141c1fd0-2169-4444-a4f9-387302ed8fb7"), Type = TextBlockType.Text, Text = "Your limbs produce strange, sucker-like growths that allow you to adhere to walls, objects, and most other surfaces. You gain a climb Speed equal to your half your land Speed (minimum 5 feet). If you have the (feat: Quick Climb) feat, your climb Speed is equal to your land Speed. In addition, you gain a +2 circumstance bonus to your Reflex DC to avoid being (action: Disarmed | Disarm)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3faa9e0d-ba6e-4795-8f94-cd7068e3fe8f"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e89bffe-63c6-4912-a0bc-628e2f4d96bb"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
