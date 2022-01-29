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
    public class EphemeralTracking : Template
    {
        public static readonly Guid ID = Guid.Parse("07b8d2a7-cdce-4668-8ee7-4ba4e1739180");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ephemeral Tracking",
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
            yield return new TextBlock { Id = Guid.Parse("7f0d9c7a-a012-4ca8-8c62-fc9bff34bb8b"), Type = TextBlockType.Text, Text = $"You are able to track your quarry through impossible places. You gain the {ToMarkdownLink<Models.Entities.Spell>("ephemeral tracking", Spells.Instances.EphemeralTracking.ID)} warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f10ad8cb-b9cc-4e7e-ac8c-7b227dba43d3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificClass(Guid.Parse("041bedab-adf9-42a0-a8f9-53988d60691d"), Classes.Instances.Ranger.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("697fc2ce-5d8b-4b33-b841-1ede0221ad64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
