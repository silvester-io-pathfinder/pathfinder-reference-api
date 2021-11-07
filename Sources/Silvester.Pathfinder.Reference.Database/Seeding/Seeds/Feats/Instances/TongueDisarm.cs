using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TongueDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("6f48e23b-6a8c-4fef-9503-7562e84b0771");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tongue Disarm",
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
            yield return new TextBlock { Id = Guid.Parse("f1b27220-e902-4de3-a0f3-15246d7c576a"), Type = TextBlockType.Text, Text = "You lash out with your tongue to disarm your foe. You attempt to (action: Disarm) a creature within 10 feet, ignoring the requirement that you must have at least one hand free." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("682fb00a-c779-4561-9c37-aa14e3c04b13"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("d95828f0-e6ac-4180-9b51-bf89b88995cb"), Feats.Instances.LightningTongue.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adf7d9a5-7caf-44f5-8542-49345997c6c0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
