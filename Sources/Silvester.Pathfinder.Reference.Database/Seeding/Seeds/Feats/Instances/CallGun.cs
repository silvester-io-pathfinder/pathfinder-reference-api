using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallGun : Template
    {
        public static readonly Guid ID = Guid.Parse("0514730c-86f6-4332-80cb-62ccdb166308");

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
            yield return new TextBlock { Id = Guid.Parse("ad1f3a88-6ae9-4377-bb6b-760530ad339d"), Type = TextBlockType.Text, Text = "You build a powerful magical connection with a chosen gun or crossbow, gaining the ability to conjure it directly to your hand from any distant location. During your daily preparations, choose a single crossbow or firearm. Until your next daily preparations, you can use the (action: Call Gun | Action - Call Gun) action to call the gun to your hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4e1cc148-1c3d-4bc9-b8f9-c9fc15fc5cd8"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ab3cb26-1286-4709-9077-c35c476c7f44"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
