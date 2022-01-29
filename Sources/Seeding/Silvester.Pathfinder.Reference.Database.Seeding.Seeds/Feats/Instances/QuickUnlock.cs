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
    public class QuickUnlock : Template
    {
        public static readonly Guid ID = Guid.Parse("45db265d-f4b5-4dc8-9c99-93e4b6fbd18a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Unlock",
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
            yield return new TextBlock { Id = Guid.Parse("de35f0a1-ede5-44e9-ba09-b8451daf027b"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.SkillAction>("Pick a Lock", SkillActions.Instances.PickALock.ID)} using 1 action instead of 2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e6e14b89-3a9e-4869-aa4c-16ce0ceefb85"), Proficiencies.Instances.Master.ID, Skills.Instances.Thievery.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4018d4af-c300-4fa9-a511-f61c333c1004"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("0d7c5873-d2fe-4375-84ba-1d41f1affc65"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("718797d7-f329-4825-a986-d9c1fddda2c3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
