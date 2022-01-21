using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoveredReload : Template
    {
        public static readonly Guid ID = Guid.Parse("77593ed3-66a9-4fdd-b073-c597ff703d99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Covered Reload",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc242fc6-03cc-4e10-ba45-6ee4ad50ff6f"), Type = TextBlockType.Text, Text = $"You duck into a safe position or minimize your profile while reloading to make your next attack. Either {ToMarkdownLink<Models.Entities.Action>("Take Cover", Actions.Instances.TakeCover.ID)} or attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)}, then {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload. As normal, you must meet the requirements to {ToMarkdownLink<Models.Entities.Action>("Take Cover", Actions.Instances.TakeCover.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)}; you must be prone, benefiting from cover, or near a feature that allows you to {ToMarkdownLink<Models.Entities.Action>("Take Cover", Actions.Instances.TakeCover.ID)}, and you need to be benefiting from cover or concealed to a creature to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} from that creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("066815ac-6947-4c35-963c-dfbce6c3cf0a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
