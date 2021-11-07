using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("cf4a2b21-8f56-46ac-80d8-bd27c37cee0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37535b96-52f3-4b17-9f6b-c0be520de304"), Type = TextBlockType.Text, Text = "Once per day, you can infuse a weapon you are carrying with magical energies that allow it to strike true against incorporeal undead. The weapon gains the effects of the (item: ghost touch | Ghost Touch Runestone) property rune for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("937fb03c-14ab-4179-8b39-57a4985e157e"), Type = TextBlockType.Text, Text = "At 10th level, you can apply this effect to two weapons instead of one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("581b8505-69e1-4ea5-8221-61d9a7dc4f89"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8faf1303-33bf-47a8-a815-e192babed0d9"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
