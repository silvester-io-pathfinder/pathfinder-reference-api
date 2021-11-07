using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RepurposedParts : Template
    {
        public static readonly Guid ID = Guid.Parse("0094a5bb-b1f7-4acd-8415-93cf6638ecf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Repurposed Parts",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f16da43-db51-49d2-ad28-3583a0cf2e71"), Type = TextBlockType.Text, Text = "You are familiar with the fittings and cogwheels of your snares and can repurpose parts from prepared quick-deploy snares to assemble a new creation on the fly. Using two of the snares you prepared for quick deployment during daily preparations, you can quickly deploy a different snare that you know how to (action: Craft), even if you didn’t prepare that snare during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("378da01f-91b7-4365-a35e-283f9d742987"), Feats.Instances.TrapsmithDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58be7f31-0d6b-4605-8426-3f809be8957c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
