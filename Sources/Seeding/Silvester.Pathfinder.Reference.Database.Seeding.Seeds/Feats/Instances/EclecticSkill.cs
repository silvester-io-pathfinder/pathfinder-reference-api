using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticSkill : Template
    {
        public static readonly Guid ID = Guid.Parse("a70c6ba8-4f6d-48ad-821a-2bd5716da995");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Skill",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5c54667-a65e-4c1c-8eb5-fb1aeb976651"), Type = TextBlockType.Text, Text = $"Your broad experiences translate to a range of skills. Your proficiency bonus to untrained skill checks is equal to your level. You can attempt any skill check that normally requires you to be trained, even if you are untrained. If you have legendary proficiency in Occultism, you can attempt any skill check that normally requires you to have expert proficiency, even if untrained or trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("9db1b998-f94b-46b4-a5ea-dc3da7a09a1b"), Muses.Instances.Polymath.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("32285a23-00c2-462c-8c11-a0cfcd600672"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("feb6cdf6-dfe1-47cf-a5a7-28cebce0c177"), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efe04c14-40ff-43bb-a152-be0a81329207"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
