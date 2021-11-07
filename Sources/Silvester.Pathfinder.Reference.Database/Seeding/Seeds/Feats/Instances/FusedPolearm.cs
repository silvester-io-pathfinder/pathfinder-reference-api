using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FusedPolearm : Template
    {
        public static readonly Guid ID = Guid.Parse("c4977123-0b49-4573-9ed5-f0b399a304a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fused Polearm",
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
            yield return new TextBlock { Id = Guid.Parse("4854c38c-241c-497f-8469-8f0702fb0b7f"), Type = TextBlockType.Text, Text = "During your daily preparations, you can magically fuse your arcane bonded weapon and a magical staff together into one item, with the staff making up the haft of the weapon. You prepare the staff at the same time you do this, and you can do this only with a staff you’re able to prepare. This fusion lasts until the next time you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("32a187fe-b088-4c36-bedd-63f2c4b9f954"), Type = TextBlockType.Text, Text = "While the two are fused, the weapon’s haft takes on aesthetic aspects of the staff." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9142b26a-920c-4c5f-8034-4394325ab2f9"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81fc6b1b-ce97-440c-b225-87a74842fa41"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
