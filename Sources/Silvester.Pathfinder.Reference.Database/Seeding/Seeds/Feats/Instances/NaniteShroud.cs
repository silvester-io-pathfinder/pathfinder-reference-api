using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaniteShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("e54558bb-cfc8-4847-87eb-811bc23b322b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nanite Shroud",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("709b98fc-a1ad-4f63-8071-18d12e63fa41"), Type = TextBlockType.Text, Text = "Your nanites fly out of your body, swarming around you in a cloud. You become concealed for a number of rounds equal to half your level. You can’t use this concealment to (action: Hide) or (action: Sneak), as normal for concealment that makes your position obvious. While Nanite Shroud is active, you can’t use other abilities that require the use of your nanites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("235c4a08-ad3b-48e6-8a5a-4ad184990281"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
