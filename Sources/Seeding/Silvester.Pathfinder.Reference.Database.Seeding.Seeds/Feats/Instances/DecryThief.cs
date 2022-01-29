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
    public class DecryThief : Template
    {
        public static readonly Guid ID = Guid.Parse("3ccb7054-6ea8-4676-8a07-afea5f727b44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Decry Thief",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("463134ea-7f62-43c6-b24c-7a00f5dad066"), Type = TextBlockType.Text, Text = $"When you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}, you can make it harder for the target to flee, in place of the action's normal effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("846e6e81-e93d-4012-8258-3933fe940d0f"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b361db4b-577a-414f-a7c0-f179d89f526c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2dea9ea9-7555-461b-ba70-9516eea2f0e8"),
                CriticalSuccess = "For 1 round, the target takes a -10-foot status penalty to Speed and a -4 status penalty to Stealth.",
                Success = "For 1 round, the target takes a -5-foot status penalty to Speed and a -2 status penalty to Stealth.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e533180-551a-45f2-b4a3-e0d91e13857d"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
