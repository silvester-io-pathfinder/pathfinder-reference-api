using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShootersCamouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("f93a239e-49dc-4221-b6bd-9f798f51c99c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shooter's Camouflage",
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
            yield return new TextBlock { Id = Guid.Parse("43efcfa2-4efb-4597-b096-108c16cd63a6"), Type = TextBlockType.Text, Text = "You specialize in blending into a particular type of environment, able to disappear after taking your shot. Choose either natural or urban terrain. In the chosen terrain, you can (action: Hide) and (action: Sneak) even without cover or being concealed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4221a241-f40c-4fcf-bad0-05d211e51fdf"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1eccd94-f4d1-4ec7-807f-de7b34eb08eb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
