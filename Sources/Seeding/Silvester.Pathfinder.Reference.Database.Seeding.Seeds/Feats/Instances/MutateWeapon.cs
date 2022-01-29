using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MutateWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("b4881de8-ee27-4d73-bb30-bbbbff5db2a6");

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
            yield return new TextBlock { Id = Guid.Parse("b65d3500-8adf-425e-a8db-7339569c7f58"), Type = TextBlockType.Text, Text = $"Select one unarmed attack you gained with {ToMarkdownLink<Models.Entities.Feat>("Living Weapon", Feats.Instances.LivingWeapon.ID)}. The damage die for that attack increases by one step until the end of your turn. In addition, choose to either have the attack gain a reach of 10 feet until the end of your turn or for you to gain a +1 status bonus to attack rolls with the chosen unarmed attack until the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e1b63a0-e10a-4d7b-bb2f-616d8928b6f6"), Feats.Instances.LivingWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc7da596-d735-4563-9bff-7cfe04b3f482"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
