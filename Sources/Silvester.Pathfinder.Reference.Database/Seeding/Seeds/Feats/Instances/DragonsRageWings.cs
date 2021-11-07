using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonsRageWings : Template
    {
        public static readonly Guid ID = Guid.Parse("07ecd142-602c-49de-b563-ecaa6974c5c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Rage Wings",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("933dbb40-1bc9-45c1-a752-a28f65449460"), Type = TextBlockType.Text, Text = "You sprout dragon wings from your back of the same color as your chosen dragon. While you are raging, you gain a fly Speed equal to your land Speed. If you are flying when your rage ends, you start to fall but the transformation only completes at the last moment, so you take no damage from the fall and land standing up." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("0911394c-9807-44ae-adc6-0c031315d5b6"), Instincts.Instances.DragonInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37b11358-6f06-4854-b179-b7d7422f189e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
