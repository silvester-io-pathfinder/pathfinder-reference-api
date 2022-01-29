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
    public class EducatedAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("c1353770-e684-4a90-8da6-8f8ccd653764");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Educated Assessment",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55e9f26c-3d1a-4981-9181-f3ff25e7aea1"), Type = TextBlockType.Text, Text = $"You attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about a creature, and the GM uses the same secret roll result against the creature's Deception or Stealth DC, giving you the information from a {ToMarkdownLink<Models.Entities.Feat>("Battle Assessment", Feats.Instances.BattleAssessment.ID)}. You might get a different degree of success on the {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} check than what you get for the {ToMarkdownLink<Models.Entities.Feat>("Battle Assessment", Feats.Instances.BattleAssessment.ID)}. If you have the {ToMarkdownLink<Models.Entities.Feat>("Battle Assessment", Feats.Instances.BattleAssessment.ID)} feat, you gain the effects of Educated Assessment whenever you {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} (such as with the {ToMarkdownLink<Models.Entities.Feat>("Automatic Knowledge", Feats.Instances.AutomaticKnowledge.ID)} feat)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cdb9965c-de84-4639-9b9d-3291b9cd3212"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Secret.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bde5cee1-12cc-4ca0-9129-e325d27007f5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
