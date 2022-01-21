using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgonizingRebuke : Template
    {
        public static readonly Guid ID = Guid.Parse("14882d43-b202-4133-99f1-234d06653790");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agonizing Rebuke",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3267c31b-8088-44d9-b13b-36bba23acc5f"), Type = TextBlockType.Text, Text = $"When you terrorize your enemies, you also cause them painful mental distress. When you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} a foe, that foe takes 1d4 mental damage at the start of each of its turns as long as it remains frightened and continues to engage in combat with you. If you have master proficiency in Intimidation, the damage increases to 2d4, and if you have legendary proficiency, the damage increases to 3d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("081b2e2f-702c-42db-ae31-a5dac2f5fb3a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
