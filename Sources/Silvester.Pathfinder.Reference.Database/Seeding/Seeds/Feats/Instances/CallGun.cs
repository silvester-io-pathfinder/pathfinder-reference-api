using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallGun : Template
    {
        public static readonly Guid ID = Guid.Parse("ff0c7c28-f83b-4ce5-bc61-c1294b7f09fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Gun",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11086be2-f928-4792-ab29-351f7fe38fd2"), Type = TextBlockType.Text, Text = "You build a powerful magical connection with a chosen gun or crossbow, gaining the ability to conjure it directly to your hand from any distant location. During your daily preparations, choose a single crossbow or firearm. Until your next daily preparations, you can use the (action: Call Gun | Action - Call Gun) action to call the gun to your hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0763ac09-c1b0-472d-8070-bf2d7e825406"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("590fe451-0096-4c93-9ce7-df6542b1ea49"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
