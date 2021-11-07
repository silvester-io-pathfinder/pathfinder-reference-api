using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnstoppableJuggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("936704a1-7837-44a3-932c-fa4363ab5b18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unstoppable Juggernaut",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47a18b3d-6bad-4849-9bad-79585ad1d9c4"), Type = TextBlockType.Text, Text = "You have become a brutal, unstoppable force of nature, able to shrug off mortal wounds with ease. You gain resistance equal to 3 + your Constitution modifier to all damage, and your resistance from raging increases to 8 + your Constitution modifier." };
            yield return new TextBlock { Id = Guid.Parse("846ce8a9-e003-45eb-904b-f8168335e61c"), Type = TextBlockType.Text, Text = "In addition, if you are reduced to 0 Hit Points while raging, you can end your rage as a reaction to stay at 1 Hit Point. If you do, you become wounded 2 (or increase your wounded condition by 2 if you are already wounded)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a88590a0-87f1-4486-841b-ba06c3b11872"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
