using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ApexCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("9df2ddb5-ef4f-4649-af8f-9fc8b526fa97");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Apex Companion",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a3654ac-a07f-4533-81d9-0ac312ca22cb"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor's Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("500f24cd-6484-45dc-bfbd-bc36be9612f6"), Type = TextBlockType.Text, Text = "You can call upon the essence of every individual animal of a particular species to temporarily transform your animal into an exemplar of its kind. You learn the (spell: apex companion) order spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9cc2377-f4f0-4988-af2a-564ddfee84c4"), Feats.Instances.AnimalCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("523ed108-7bc3-4d37-9159-8421af3e7ef0"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
