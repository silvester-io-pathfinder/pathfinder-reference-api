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
    public class AssassinDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ee84f8a2-f2a2-40f6-a213-c930cf3709ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assassin Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the assassin archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02c071ad-2304-456a-a03c-72350c3602c0"), Type = TextBlockType.Text, Text = $"You've trained to assassinate your foes, and you do so with tenacity and precision. You gain the {ToMarkdownLink<Models.Entities.Feat>("Mark for Death", Feats.Instances.MarkForDeath.ID)} activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ee7d220d-c274-4895-8568-cf59af8962be"), Feats.Instances.AlchemicalCrafting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("645a6e34-4a98-4fbf-ae8c-4884eb96db93"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5e516bf9-2c77-444c-9c38-65a5a1ef3f3e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("57ffca3f-1d1c-4926-8ac4-d9d564f810e1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3434612c-03d3-4949-9142-2b5fd36ee890"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
