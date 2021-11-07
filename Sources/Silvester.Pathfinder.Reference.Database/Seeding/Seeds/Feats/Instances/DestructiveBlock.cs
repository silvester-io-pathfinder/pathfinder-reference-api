using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DestructiveBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("edea14d5-5f3a-431e-8192-47e269891537");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Destructive Block",
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
            yield return new TextBlock { Id = Guid.Parse("ad9e426d-53e4-4aae-912a-6679e6d1a622"), Type = TextBlockType.Text, Text = "You can protect yourself more effectively, at the expense of your shield. When you (feat: Shield Block), you can reduce the damage to yourself by double the shield’s Hardness, but if you do, the shield takes double the normal amount of damage it would have taken (before applying its Hardness). You can’t use Destructive Block if your shield can’t be broken or destroyed, such as if you’re using an (item: indestructible shield)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6dc2deb1-366b-4055-b6c5-11d198f4585d"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d302fd2e-e1de-4652-8dc3-831f563c12d7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
