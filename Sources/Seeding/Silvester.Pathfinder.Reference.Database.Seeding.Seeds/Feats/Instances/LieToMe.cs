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
    public class LieToMe : Template
    {
        public static readonly Guid ID = Guid.Parse("dd09ff78-d629-41c3-ab24-9e8b430949ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lie to Me",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adf66035-7b75-4abc-b776-43eb6b440179"), Type = TextBlockType.Text, Text = $"You can use Deception to weave traps to trip up anyone trying to deceive you. If you can engage in conversation with someone trying to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} to you, use your Deception DC if it is higher than your Perception DC to determine whether they succeed. This doesn't apply if you don't have a back-and-forth dialogue, such as when someone attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} during a long speech." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e8ca04bb-4db4-452a-afb6-01db1692fa78"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbaeb87e-09c7-4dee-adfd-84817f83d012"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
