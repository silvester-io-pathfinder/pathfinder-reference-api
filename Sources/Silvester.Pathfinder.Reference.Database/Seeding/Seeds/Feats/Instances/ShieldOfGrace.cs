using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldOfGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("b9d7cadf-0c78-4f8c-9402-d179c4ec5a14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield of Grace",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15f1ec86-0de9-480f-bea9-5eeb22a3eca5"), Type = TextBlockType.Text, Text = "You protect an ally with both your shield and your body. Whenever you use the (feat: Shield Block) reaction to prevent damage to an ally, you can evenly split the remaining damage after the (feat: Shield Block) between the ally and yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a16a8426-bf1e-423e-a7ef-7a96db4180e4"), Feats.Instances.ShieldWarden.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d222c4e-cbd4-4efb-a162-04da8dcea356"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
