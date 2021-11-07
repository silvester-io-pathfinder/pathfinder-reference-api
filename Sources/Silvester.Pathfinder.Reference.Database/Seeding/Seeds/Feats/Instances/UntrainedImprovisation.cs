using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UntrainedImprovisation : Template
    {
        public static readonly Guid ID = Guid.Parse("7e0ff367-d878-4704-a89c-8f9f63aad7d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Untrained Improvisation",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e73eba4-9559-432f-8211-7397d0691b0e"), Type = TextBlockType.Text, Text = "You’ve learned how to handle situations when you’re out of your depth. Your proficiency bonus to untrained skill checks is equal to half your level instead of +0. If you’re 7th level or higher, the bonus increases to your full level instead. This doesn’t allow you to use the skill’s trained actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4392431d-307f-4d7f-9ff0-374f743392b0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
