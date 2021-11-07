using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VeilMay : Template
    {
        public static readonly Guid ID = Guid.Parse("f4b3df31-a3a0-45ff-9676-6b4c5be59930");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Veil May",
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
            yield return new TextBlock { Id = Guid.Parse("98e7d2f9-b008-4b41-bec3-a6ca5a595516"), Type = TextBlockType.Text, Text = "Born of a blood hag, a fiery blood drinker hidden behind a false skin, you have one blood-red eye and the ability to slough off your appearance in an instant. You gain the (feat: Lie to Me) skill feat, and you can shed a disguise quickly by peeling off the outer layer of your skin. Changing from a disguise used to (action: Impersonate) back to your true appearance is a 3-action activity for you; if you’re an expert in Deception, it’s a 2-action activity, and if you’re legendary in Deception, it takes only a single action. This doesn’t allow you to don or remove armor or other equipment any faster, but your physical appearance otherwise returns to its normal state." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c683e4e4-167a-4a04-9eb1-a779c3525c86"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
