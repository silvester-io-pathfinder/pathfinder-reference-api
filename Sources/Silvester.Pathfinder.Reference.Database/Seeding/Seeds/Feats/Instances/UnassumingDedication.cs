using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnassumingDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ce4fd789-2397-4cb9-8d03-d6e51cc767c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unassuming Dedication",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5188c9bd-c9c2-4936-8a11-19db2773d844"), Type = TextBlockType.Text, Text = "~ Access: Uhlam ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("50451274-ec97-4ed0-a828-1c65e9f40062"), Type = TextBlockType.Text, Text = "Your family instilled the values of care and patience into you from a young age. You gain a +1 circumstance bonus to checks to perform a (trait: downtime) activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d225420-dc82-4286-b8f8-8f1e3f18ca6a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
