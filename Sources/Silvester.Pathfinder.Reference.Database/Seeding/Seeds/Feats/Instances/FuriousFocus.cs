using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("9726fafb-9271-4f78-b8de-5d9ba494fb6b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Focus",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d676568-3696-48e1-9320-612701fb208c"), Type = TextBlockType.Text, Text = "You’ve learned to maintain your balance even when swinging furiously. When you make a (Feat: Power Attack) with a melee weapon you’re wielding in two hands, it counts as one attack toward your multiple attack penalty instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c46649c-8597-4423-a4a5-ac4a89d9fdf1"), Feats.Instances.PowerAttack.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e065c5ff-e78d-4372-a53a-dcf3aa893904"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
