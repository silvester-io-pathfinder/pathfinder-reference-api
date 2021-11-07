using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("ff12f448-0801-4bfe-a4a3-3f78f2b6faea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch Warden",
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
            yield return new TextBlock { Id = Guid.Parse("9a2ee63a-3c11-44d2-8069-342620563868"), Type = TextBlockType.Text, Text = "~ Access: Kellid ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("b7db891c-423c-44a8-8424-de0745013dcd"), Type = TextBlockType.Text, Text = "You and your family have fought long and hard against witches, particularly the winter witches of Irrisen, and you’ve learned to be wary of their curses and the otherworldly powers their patrons grant. You gain a +1 circumstance bonus to saving throws against curses, and to saving throws against spells cast by a witch or hag. If you roll a success on a saving throw against a curse or a spell cast by a witch or hag, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84c98096-8c13-46f2-8539-6e86543c3c52"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
