using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensStep : Template
    {
        public static readonly Guid ID = Guid.Parse("3719fa73-c3af-4d24-a24d-f27e57c5f3a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Step",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f56da170-8906-4f16-8c11-ac7a48b9e3aa"), Type = TextBlockType.Text, Text = "You can guide your allies to move quietly through the wilderness. When you (action: Sneak) during exploration in natural terrain, you can designate any number of your allies to gain the benefits as if they were using that activity during that exploration. This requires no action on their part." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ee15bcb-6e38-433d-a4aa-94203adcd4ec"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("e320c1f3-3f66-4751-88cc-609a018172d0"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ead40ae-22a4-411b-8012-7c2c20ef6087"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
