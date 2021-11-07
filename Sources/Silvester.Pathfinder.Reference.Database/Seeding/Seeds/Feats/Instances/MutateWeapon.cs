using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MutateWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("9cb18f4d-2ae0-4e14-a71f-749ccd82e4d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mutate Weapon",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71586c93-2818-48d3-929f-31c6a1ff6582"), Type = TextBlockType.Text, Text = "Select one unarmed attack you gained with (feat: Living Weapon). The damage die for that attack increases by one step until the end of your turn. In addition, choose to either have the attack gain a reach of 10 feet until the end of your turn or for you to gain a +1 status bonus to attack rolls with the chosen unarmed attack until the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("00eb8bb4-773b-40cc-ab3d-5d7774bfde81"), Feats.Instances.LivingWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bf5e6ec-d36f-4a49-98b7-b3fbac95213d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
