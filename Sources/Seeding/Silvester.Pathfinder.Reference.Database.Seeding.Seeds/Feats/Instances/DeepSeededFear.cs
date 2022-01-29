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
    public class DeepSeededFear : Template
    {
        public static readonly Guid ID = Guid.Parse("6e217257-0923-4595-954c-de3c5a18a85c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep-Seeded Fear",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc191e7d-f252-48e7-8a30-00dbc02bc04d"), Type = TextBlockType.Text, Text = $"You gain a +2 status bonus to your Intimidation checks and don't take any penalties for not sharing a language when {ToMarkdownLink<Models.Entities.SkillAction>("Demoralizing", SkillActions.Instances.Demoralize.ID)} foes who can perceive your armament's essence form. When you manifest the essence form, you can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} an enemy who can perceive the manifestation." };
            yield return new TextBlock { Id = Guid.Parse("e5aadbe3-1000-4a57-9702-d5af218ca483"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ If you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} an enemy, your {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} also targets the ally closest to you.get. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} uses the same multiple attack penalty as the missed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and doesn't count toward your multiple attack penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c25a80fc-48d2-40cd-9c28-e14d24f466a6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
