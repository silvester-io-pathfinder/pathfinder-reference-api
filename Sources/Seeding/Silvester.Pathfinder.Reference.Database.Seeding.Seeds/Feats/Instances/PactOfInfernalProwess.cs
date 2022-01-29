using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PactOfInfernalProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("ac95cc9d-314c-41db-a2c2-90abd72445d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pact of Infernal Prowess",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't retrain out of a Pact of Infernal Prowess without journeying to Hell and destroying the devil's written contract spelling out the terms of your pact.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a430937d-62c6-4c5e-8f2f-697db2912476"), Type = TextBlockType.Text, Text = $"You've sworn a pact with devils, granting you success in life in exchange for your soul in the afterlife. Once per day, when you critically fail a check, you can reroll the check as a free action; this is a {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effect. Additionally, you can choose to automatically succeed at checks to {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} for tasks below your level, without rolling." };
            yield return new TextBlock { Id = Guid.Parse("2fc0ecd2-3575-4bed-ad3e-800a78a84068"), Type = TextBlockType.Text, Text = $"However, when you die, your soul is consigned to Hell. You can't be returned to life except by powerful magic such as {ToMarkdownLink<Models.Entities.Spell>("miracle", Spells.Instances.Miracle.ID)}, and even then, the devils responsible for the contract can track your every move for 1 year. The devils gain the effects of a {ToMarkdownLink<Models.Entities.Spell>("discern location", Spells.Instances.DiscernLocation.ID)} spell. They can also use 10th-level {ToMarkdownLink<Models.Entities.Spell>("scrying", Spells.Instances.Scrying.ID)} on you at will, and you automatically critically fail your saving throw." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7342ca57-af82-4045-b1d3-580ac0ca624b"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
