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
    public class FindFlaws : Template
    {
        public static readonly Guid ID = Guid.Parse("89ed3649-eb76-41d2-ad0d-51a5cb6f0171");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Find Flaws",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a67c5c4b-088b-414d-82e8-a2c93df66691"), Type = TextBlockType.Text, Text = $"You determine a creature's weaknesses, whether a literal weakness or a metaphysical one. {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about a creature, using your Charisma modifier instead of the usual ability modifier for the skill you're using to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. The creature must be either one you can see or one you're specifically Investigating in advance during exploration. The result depends on your {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} check, which has the following additional effects as well as the usual effects of {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8137c832-672c-4767-87f7-b706414f7710"),
                CriticalSuccess = "You learn all of the creature's resistances, weaknesses, and immunities. If you would have learned any of them already from (action: Recall Knowledge), you learn different information instead. You can then use (feat: Esoteric Antithesis) without spending an additional action.",
                Success = "You learn the creature's highest weakness, if any. If you would have learned it already from (action: Recall Knowledge), you learn different information instead. You can then use (feat: Esoteric Antithesis) without spending an additional action.",
                Failure = "You couldn't quite figure it out, so you decide to invoke a wide range of superstitions and narrow it down from there. You can use (feat: Esoteric Antithesis) as your next action.",
                CriticalFailure = "You came up with the wrong information and nearly made a critical mistake, distracting yourself. You become flat-footed until the beginning of your next turn and can't use (feat: Esoteric Antithesis) this round.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a4227db-c637-4298-9e26-2b32944ba0a4"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
