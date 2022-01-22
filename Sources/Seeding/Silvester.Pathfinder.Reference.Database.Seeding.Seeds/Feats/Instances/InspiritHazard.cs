using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspiritHazard : Template
    {
        public static readonly Guid ID = Guid.Parse("9c4685c0-99e4-4639-ae35-7478e9618acf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspirit Hazard",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Disable a hazard.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c21253ec-28e6-4a62-9230-2c63200b0862"), Type = TextBlockType.Text, Text = $"You awaken a spirit of creation within the hazard. You learn the hazard's effects. Once in the next 10 minutes, when you observe a creature take an action that would trigger one of the hazard's reactions or free actions if you hadn't {ToMarkdownLink<Models.Entities.SkillAction>("Disabled", SkillActions.Instances.DisableADevice.ID)} it, you can use a reaction to rearm the hazard, causing the observed creature to trigger it immediately." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa320c5f-033b-41de-99de-ef3f1e80ab89"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
