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
    public class EndemicHerbs : Template
    {
        public static readonly Guid ID = Guid.Parse("6eda7836-dc38-4afc-b6e1-480a3c4ba26d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Endemic Herbs",
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
            yield return new TextBlock { Id = Guid.Parse("56d9d662-fa15-4026-8db2-5ef7d0d043f9"), Type = TextBlockType.Text, Text = $"During your daily preparations, you find medicinal plants endemic to your location. Until your next preparations, you can spend an additional batch of herbs to add a benefit to an item you create with your herbalism. The benefit of the special herbs affects the creature that the item is applied to. This adjustment counts as an {ToMarkdownLink<Models.Entities.Trait>("additive 1", Traits.Instances.Additive.ID)}, so you can't include another additive without spoiling the item." };
            yield return new TextBlock { Id = Guid.Parse("ffae8d70-98ff-4ecc-97a0-c903ea3ec7db"), Type = TextBlockType.Enumeration, Text = $" Aquatic: For 1 minute, gain a +1 circumstance bonus to Fortitude saves." };
            yield return new TextBlock { Id = Guid.Parse("437e340f-2400-48cf-8672-cd8c88b7bfda"), Type = TextBlockType.Enumeration, Text = $" Arctic: For 1 hour, treat environmental cold effects as if they were one step less severe." };
            yield return new TextBlock { Id = Guid.Parse("571fcf9b-f212-4e2f-aa1b-c889971d5cd6"), Type = TextBlockType.Enumeration, Text = $" Desert: For 1 hour, treat environmental heat effects as if they were one step less severe." };
            yield return new TextBlock { Id = Guid.Parse("93247dba-3901-4b5a-9797-3cd3c5e14ca9"), Type = TextBlockType.Enumeration, Text = $" Forest: For 1 minute, gain a +2 circumstance bonus to saves against {ToMarkdownLink<Models.Entities.Trait>("disease", Traits.Instances.Disease.ID)} and {ToMarkdownLink<Models.Entities.Trait>("poison", Traits.Instances.Poison.ID)} effects." };
            yield return new TextBlock { Id = Guid.Parse("cbe6db52-b432-406e-9d91-cf84874141cc"), Type = TextBlockType.Enumeration, Text = $" Mountain: For 1 minute, gain a +1 circumstance bonus to Reflex saves." };
            yield return new TextBlock { Id = Guid.Parse("baec16d3-8234-4c60-b40e-8be0a65d0db8"), Type = TextBlockType.Enumeration, Text = $" Plains: For 1 minute, gain a +1 circumstance bonus to Will saves." };
            yield return new TextBlock { Id = Guid.Parse("20c25089-2ddc-4e2e-8803-a93d6e603e73"), Type = TextBlockType.Enumeration, Text = $" Swamp: Remove one source of persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("2adb1cf4-5397-4467-801d-bf56bf369024"), Type = TextBlockType.Enumeration, Text = $" Underground: For 1 minute, gain a +1 circumstance bonus to Perception." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13223e81-06d8-4a6b-8470-9a4df212ee74"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("78f5358d-523b-46f2-a791-016515d4ac57"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e9cf1d2-73a9-4250-aa0b-f95169209220"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
