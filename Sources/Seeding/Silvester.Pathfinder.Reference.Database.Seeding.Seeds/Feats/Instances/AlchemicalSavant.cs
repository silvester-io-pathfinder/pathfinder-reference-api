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
    public class AlchemicalSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("036900fa-d8c4-4678-9820-0b88dab442cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Savant",
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
            yield return new TextBlock { Id = Guid.Parse("c146e76b-9a29-4323-84f8-3526af22add0"), Type = TextBlockType.Text, Text = $"You can identify alchemical items quickly. When using the Crafting skill to {ToMarkdownLink<Models.Entities.SkillAction>("Identify Alchemy", SkillActions.Instances.IdentifyAlchemy.ID)} on an alchemical item you hold, you can do so as a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} and {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} traits, instead of spending 10 minutes. If you have the formula for the item you are attempting to identify, you gain a +2 circumstance bonus to your check, and if you roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bdb32d8d-f4b8-44d6-a9bb-707c93e9a499"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0699e9d7-11ce-48a7-8fe5-2cfe6901b241"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
