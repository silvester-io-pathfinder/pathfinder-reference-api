using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JustOneMoreThing : Template
    {
        public static readonly Guid ID = Guid.Parse("8010da41-41d1-4e1a-bb2f-013010038da0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Just One More Thing",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fdc87bf-60bc-45e0-83e0-da8981f1389b"), Type = TextBlockType.Text, Text = $"After your attempt to influence someone goes poorly, you add another bit of information or ask a pointed question, possibly salvaging your previous attempt. Reroll the failed check and use the new result. If the target of the failed check is the subject of a lead you're pursuing, double your bonus from {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)} on the rerolled check. That creature is temporarily immune to Just One More Thing for 1 day." };
            yield return new TextBlock { Id = Guid.Parse("617b0b4a-cb41-40d4-84a4-8f775fb9a4ef"), Type = TextBlockType.Text, Text = $"You can also use this action if you failed, but didn't critically fail, at a check to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Gather Information", SkillActions.Instances.GatherInformation.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Coerce", SkillActions.Instances.Coerce.ID)}. In this case, rather than spending 1 action, adding Just One More Thing takes you half the amount of time you initially spent on the check, to a minimum of 1 more round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02953dd4-a395-4319-a9ab-5a7aec3a9941"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
