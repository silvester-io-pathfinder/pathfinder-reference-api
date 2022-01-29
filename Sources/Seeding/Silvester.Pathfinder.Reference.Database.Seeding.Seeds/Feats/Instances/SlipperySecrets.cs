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
    public class SlipperySecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("6ba64589-878f-4ca0-a3c8-844e64da3666");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slippery Secrets",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d034f9c-42ff-4aad-bfb1-d94320d27e43"), Type = TextBlockType.Text, Text = $"You elude and evade attempts to uncover your true nature or intentions. When a spell or magical effect tries to read your mind, detect whether you are lying, or reveal your alignment, you can attempt a Deception check against the spell or effect's DC. If you succeed, the effect reveals nothing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5a939217-534e-42e9-a830-9523774c76d1"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("32fd2206-430f-47bc-acc4-750dd4e5162c"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("8b3e76ea-25bb-4477-8dfa-5cf72a8da16e"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e808c773-c371-4a6d-9485-5a5e48433f0f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
