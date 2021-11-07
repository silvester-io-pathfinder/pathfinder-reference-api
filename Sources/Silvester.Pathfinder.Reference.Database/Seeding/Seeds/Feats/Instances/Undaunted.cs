using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Undaunted : Template
    {
        public static readonly Guid ID = Guid.Parse("a270bce0-9710-4840-a012-3cbb38768fc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undaunted",
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
            yield return new TextBlock { Id = Guid.Parse("fb59656c-1825-47b1-a9bc-e56202079acc"), Type = TextBlockType.Text, Text = "Your spirit has endured many challenges over its long existence, and you are certain you can overcome whatever hardships life throws your way. You gain a +1 circumstance bonus to saves against emotion effects. If you roll a success on a saving throw against an emotion effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5d80c54-d63d-4570-8cf2-49b4664e92cc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
