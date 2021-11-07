using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StaveOffCatastrophe : Template
    {
        public static readonly Guid ID = Guid.Parse("6e8e7543-a2d3-459a-9a0b-ed901e365707");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stave Off Catastrophe",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07692ef4-2f17-457a-8a6a-354c351136d8"), Type = TextBlockType.Text, Text = "You fully protect your allies from the worst blows. When you use the (feat: Shoulder Catastrophe) reaction, you can choose to take the full critical damage and effects from the attack, including effects that apply on a critical hit, and have your ally take no damage and avoid the attack&#39;s effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("128d24ae-863a-4326-91fb-fe8447040107"), Feats.Instances.ShoulderCatastrophe.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd84f9b1-f3c9-4d76-8dd1-f93d64ad2b89"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
