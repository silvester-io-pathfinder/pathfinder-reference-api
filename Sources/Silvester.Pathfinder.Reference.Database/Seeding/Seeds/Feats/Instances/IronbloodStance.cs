using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronbloodStance : Template
    {
        public static readonly Guid ID = Guid.Parse("b8885a69-f96a-4fe9-ae16-e14640b728d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ironblood Stance",
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
            yield return new TextBlock { Id = Guid.Parse("6ac2e16a-299f-4293-85fc-58a73d7feeca"), Type = TextBlockType.Text, Text = "You enter the stance of impenetrable iron, refusing to yield to any blow. You can make iron sweep unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: nonlethal), (trait: parry), (trait: sweep), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("993d8969-c764-43ba-b372-c00368a6aa92"), Type = TextBlockType.Text, Text = "While in Ironblood Stance, you gain resistance 2 to all damage. The resistance increases to 3 at 12th level, to 4 at 16th level, and to 5 at 20th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f9617b9-14eb-4d38-a5a5-b48fb6a4d889"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
