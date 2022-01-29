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
    public class SnarecrafterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("151c929e-f448-4ff0-a551-6e337f576558");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snarecrafter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "The feat counts as (feat: Snare Specialist) for the purpose of feat prerequisites. If you also have the (feat: Snare Specialist) ranger feat, the quick snares from both feats are cumulative. You can't select another dedication feat until you have gained two other feats from the snarecrafter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0e76554-a6d6-499b-a719-117d97f36f2e"), Type = TextBlockType.Text, Text = $"You've learned to create a limited number of snares at no cost. Each day during your daily preparations, you can prepare four snares from your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("formula book", Items.AdventuringGears.Instances.FormulaBook.ID)} for quick deployment; if they normally take 1 minute to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} them with 3 {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions. The number of snares increases to six if you're a master in Crafting and eight if you're legendary. Snares prepared in this way don't cost you any resources to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("87f42c63-02cd-4fab-88ee-983b68b451d7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8986b90b-70ca-4eba-ac95-79d0dabd6ccc"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("9e41fefa-7b7d-4184-9dea-72cf3e5337ee"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cd9569a-17d6-412f-bf23-9c3240912a3e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
