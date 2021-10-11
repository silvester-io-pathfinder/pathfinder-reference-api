using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class EyeForNumbersFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("7403396b-6842-4b48-a10c-28de1c522f37");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye for Numbers",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6ee02f6-0a2a-4b07-ba89-4caf14500335"), Type = TextBlockType.Text, Text = "You've learned to subitize, quickly estimating the number of items in a group with relative accuracy at only a glance. You immediately learn the number of visually similar items in a group you can see (such as coins, books, or people), rounded to the first digit in the total number. For example, you could look at a case of potion vials and learn that it held about 30 vials, but you wouldn't know that it was exactly 33 vials, how many different types of potions there were, or how many of which type. Similarly, you could look at a pile of 2,805 coins and know that there were about 3,000 coins in all. You can use this ability only on items that can typically be counted, so you can't use it on grains of sand or stars in the sky, for example." };
            yield return new TextBlock { Id = Guid.Parse("627290e2-0de1-482e-9410-cb44ed477fb3"), Type = TextBlockType.Text, Text = "In addition, when you attempt to Decipher Writing that is primarily numerical or mathematical, you gain a +2 circumstance bonus to your check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e44d7030-85ee-4376-9008-a1f8e78eaea8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 206
            };
        }
    }
}
