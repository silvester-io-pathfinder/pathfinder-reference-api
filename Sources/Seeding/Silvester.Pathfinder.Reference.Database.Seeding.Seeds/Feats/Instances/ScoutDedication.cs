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
    public class ScoutDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("217f3454-ff7f-4b91-abf4-a35dc1779246");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the scout archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4874294e-9607-4010-9056-e7725fe812d5"), Type = TextBlockType.Text, Text = $"You are a highly skilled scout, capable of providing your allies a timely warning of any danger. You gain the {ToMarkdownLink<Models.Entities.Feat>("Scout's Warning", Feats.Instances.ScoutsWarning.ID)} ranger feat. When you're using the {ToMarkdownLink<Models.Entities.Activity>("Scout", Activities.Instances.Scout.ID)} exploration activity, you grant your allies a +2 circumstance bonus to their initiative rolls instead of a +1 circumstance bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("55219fe8-3f67-49ed-94f0-65b7eeda846a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5ecae656-b02a-46c0-89fc-acfe96f6f0be"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e783ecef-ab67-45ff-afeb-832177a86f45"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("3e55b6e9-9be7-45e5-9b3c-57ba1130fd6e"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc1d1589-d324-41c3-8396-461b9b3b0f60"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
