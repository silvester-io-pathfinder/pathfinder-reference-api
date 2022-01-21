using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("d053c237-2231-410a-92e7-d0972c3b3ba1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Recovery",
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
            yield return new TextBlock { Id = Guid.Parse("8d031fe6-e46c-4eb3-bb1f-950eb0eec88d"), Type = TextBlockType.Text, Text = $"Your faith provides temporary protection in addition to healing. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} on a single target and the target regains Hit Points from the spell, it also gains a +2 status bonus to AC and saving throws for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("e494480f-5562-422d-9913-f24f5bdc6f2b"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("1162a6ed-2e51-48c3-9f36-3ef905752e22"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("195cdb1e-2867-417a-bc25-3b733195eacf"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00094915-7f4a-4fed-9871-8c266e7d2240"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
