using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Intercorporate : Template
    {
        public static readonly Guid ID = Guid.Parse("41be7ce0-c772-42c4-a24e-f4f3de287b33");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intercorporate",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a578ca7-b5ed-4903-a225-c9c839a8a2c5"), Type = TextBlockType.Text, Text = "Your ordered physiology rejects unwelcome elements. Choose one." };
            yield return new TextBlock { Id = Guid.Parse("bea09e02-136f-4651-a8c9-e2a19c5b1579"), Type = TextBlockType.Enumeration, Text = " Disease or Poison: Attempt a saving throw against the affliction at its current stage. On a failure, the affliction's stage doesn't increase, but you suffer the effects of the stage you were already on. On a critical failure, the stage only increases by 1." };
            yield return new TextBlock { Id = Guid.Parse("a6662084-fa24-4a79-96b6-1adaaf5be5b4"), Type = TextBlockType.Enumeration, Text = " Persistent Damage: Attempt a DC 10 flat check to recover from the persistent damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb6cafa3-981d-44b7-8292-f3a705978779"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
