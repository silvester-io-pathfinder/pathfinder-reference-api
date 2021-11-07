using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountedShield : Template
    {
        public static readonly Guid ID = Guid.Parse("a344c550-1b0d-4900-99a4-7573aab4c9d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mounted Shield",
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
            yield return new TextBlock { Id = Guid.Parse("77b8d845-ce84-4f35-a4fc-9bfe28bc2e70"), Type = TextBlockType.Text, Text = "You’ve trained with your shield to defend both yourself and your mount. When you (action: Raise a Shield) while mounted, both you and your mount gain the shield’s circumstance bonus to AC. If you have the (feat: Shield Block) reaction, you can use it in response to your mount taking damage, as long as you’re riding your mount. If you do, the shield prevents your mount from taking damage instead of preventing you from taking damage, following the normal rules for (feat: Shield Block)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2cf1c01b-57dc-4e9a-bf82-bc30c3bb56ce"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e852e00a-8f24-406a-99d4-8ff4799c1f08"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
