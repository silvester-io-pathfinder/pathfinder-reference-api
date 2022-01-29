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
    public class BrutalBully : Template
    {
        public static readonly Guid ID = Guid.Parse("99509bd3-103b-47da-b1e7-e77a3eb676f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutal Bully",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f42f5cff-b166-4857-86bf-35fbfe26b934"), Type = TextBlockType.Text, Text = $"You push your foes around and leave bruises. While raging, when you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} a foe, you deal that foe bludgeoning damage equal to your Strength modifier; add this to the damage from a critical success to {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c1c62da3-c687-4b0d-80dd-dfddf5c0e4ec"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59e91863-cc3c-4598-8cf0-9cdf9ab30974"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
