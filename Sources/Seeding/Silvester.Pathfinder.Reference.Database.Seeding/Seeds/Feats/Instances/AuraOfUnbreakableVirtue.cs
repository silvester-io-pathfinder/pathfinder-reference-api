using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfUnbreakableVirtue : Template
    {
        public static readonly Guid ID = Guid.Parse("2f6efdd4-3e25-4c86-a88c-218b08bf2bbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Unbreakable Virtue",
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
            yield return new TextBlock { Id = Guid.Parse("1eb52801-eb62-4459-a4be-93dbcd2abcf5"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor's Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("f227bb3d-2e52-4a60-8998-34b8674ccb25"), Type = TextBlockType.Text, Text = "You are a paragon of all that is good, your overwhelming aura causing evildoers to cower. All evil creatures within 15 feet of you take a -1 status penalty to checks and DCs that target you or your allies. This penalty is -2 against creatures you have taken an oath against (such as dragons if you have the (feat: Dragonslayer Oath) feat). You can choose to suppress or resume this aura as an action, which has the (trait: concentrate) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("d0a14edd-c86a-4972-9515-10a04c6a0454"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57d26958-7d34-4eb1-a542-f6d5a7471291"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
