using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReplenishmentOfWar : Template
    {
        public static readonly Guid ID = Guid.Parse("f0d33c4c-9403-4731-8350-176075eba3cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Replenishment of War",
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
            yield return new TextBlock { Id = Guid.Parse("c9bf86f5-d3ec-42af-8e34-4429010526fc"), Type = TextBlockType.Text, Text = "Striking out against your enemies draws praise and protection from your deity. When you damage a creature with a (action: Strike) using your deity’s favored weapon, you gain a number of temporary Hit Points equal to half your level, or equal to your level if the (action: Strike) was a critical hit. These temporary Hit Points last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("8610463c-2f00-4cdc-9dd2-311e639af366"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d82c3ea-2edf-4dd1-a942-856dc55eba06"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
