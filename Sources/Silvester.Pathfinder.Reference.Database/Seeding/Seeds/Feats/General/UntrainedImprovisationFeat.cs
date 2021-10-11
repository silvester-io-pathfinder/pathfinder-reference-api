using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class UntrainedImprovisationFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9648e97f-800c-492f-9277-93a17174bab1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Untrained Improvisation",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb92aacb-50c4-49d2-8ed0-71860ad8582e"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve learned how to handle situations when you’re out of your depth. Your proficiency bonus to untrained skill checks is equal to half your level instead of +0. If you’re 7th level or higher, the bonus increases to your full level instead. This doesn’t allow you to use the skill’s trained actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd051960-1cd8-41c8-98aa-cd72fd0671ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 268
            };
        }
    }
}
