using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BleedingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("b9c447ab-948f-4cce-b2e1-4a92f25c7235");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bleeding Finisher",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f480073-3414-4e50-ae69-ab1656c370e6"), Type = TextBlockType.Text, Text = "Your blow inflicts profuse bleeding. Make a slashing or piercing (action: Strike) with a weapon or unarmed attack that allows you to add your precise strike damage. If you hit, the target also takes persistent bleed damage equal to your precise strike finisher damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23f0cc7c-fa1c-4f32-8255-703da7e6484c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
