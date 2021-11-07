using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrixVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("0f6b597c-7739-4fb9-845a-703a887e4e5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strix Vengeance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You, or a strix ally you can see, are damaged by an enemy's critical hit.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("041a6aa8-3e77-451f-a30c-6c1327db542b"), Type = TextBlockType.Text, Text = "You dedicate yourself to destroying those who harm your kin. Until the end of your next turn, you deal an additional 1d6 damage on (action: Strikes | Strike) against the triggering enemy. The bonus increases to 2d6 if you use a (item: striking | Striking Runestone) weapon or unarmed attack and 3d6 if you use a (item: major striking | Major Striking Runestone) weapon or unarmed attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8a1e18a-c475-41f1-8ac6-e043bac85832"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
