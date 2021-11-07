using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SavageCritical : Template
    {
        public static readonly Guid ID = Guid.Parse("50b598bd-5064-46bb-9e94-38bae272df8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Savage Critical",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d42f2bc5-b704-416d-b973-0d7cd49b51f1"), Type = TextBlockType.Text, Text = "The wounds you inflict are grievous. When you (Action: Strike) with a weapon or unarmed attack for which you have legendary proficiency, you critically succeed if you roll a 19 on the die as long as that result is a success. This has no effect on a 19 if the result would be a failure." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c233470e-edaf-40d7-8f6e-69473fe21726"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
