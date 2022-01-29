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
    public class BountyHunterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("478544bf-c5fd-4baa-b1dc-ea0807238a93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounty Hunter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the bounty hunter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b95653df-274f-4fc0-86b6-74574c3e5c68"), Type = TextBlockType.Text, Text = $"When focused on finding your quarry, you're relentless. You gain the {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} action. You can use {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} to designate only a creature that you've seen, heard about, or learned about through some other means, such as a bounty board or wanted poster. In addition to the other benefits of {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)}, you gain a +2 circumstance bonus to checks to {ToMarkdownLink<Models.Entities.SkillAction>("Gather Information", SkillActions.Instances.GatherInformation.ID)} regarding your prey." };
            yield return new TextBlock { Id = Guid.Parse("045be7b4-487e-46e2-ab50-1ec03745af4a"), Type = TextBlockType.Text, Text = $"If you already have {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)}, you become an expert in Survival and gain the circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Gather Information", SkillActions.Instances.GatherInformation.ID)} about your prey; you can still designate a creature you're tracking during exploration, in addition to the conditions above." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("78b742f8-34b7-4927-bb77-614cef3b52f1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8abeda5a-9cd7-408b-ba01-cd74118a8b84"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
