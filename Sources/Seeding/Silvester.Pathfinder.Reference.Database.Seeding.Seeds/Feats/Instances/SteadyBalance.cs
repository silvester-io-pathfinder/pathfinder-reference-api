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
    public class SteadyBalance : Template
    {
        public static readonly Guid ID = Guid.Parse("c625fcb7-f405-43a9-9132-9b554c8a9ece");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady Balance",
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
            yield return new TextBlock { Id = Guid.Parse("6f2d8c1c-d193-48a8-ac83-7ae2d4004e90"), Type = TextBlockType.Text, Text = $"You can keep your balance easily, even in adverse conditions. Whenever you roll a success using the {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)} action, you get a critical success instead. You're not flat-footed while attempting to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)} on narrow surfaces and uneven ground. Thanks to your incredible balance, you can attempt an Acrobatics check instead of a Reflex save to {ToMarkdownLink<Models.Entities.Action>("Grab an Edge", Actions.Instances.GrabEdge.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5a127203-9c9e-40e2-82bf-e2e627171ced"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1c802f96-209a-44f2-816d-012466f2abdc"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("e9ba7c29-9714-46d9-848a-e354a75e909e"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("147aeb49-8ce0-4abf-a029-23b67bdca58f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
