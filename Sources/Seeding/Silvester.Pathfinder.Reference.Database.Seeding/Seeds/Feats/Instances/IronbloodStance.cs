using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronbloodStance : Template
    {
        public static readonly Guid ID = Guid.Parse("8bd3262d-93ff-471b-a0f3-9ba17188c96e");

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
            yield return new TextBlock { Id = Guid.Parse("464dc52e-c9e4-4de6-a6f7-01dc633f5d19"), Type = TextBlockType.Text, Text = "You enter the stance of impenetrable iron, refusing to yield to any blow. You can make iron sweep unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: nonlethal), (trait: parry), (trait: sweep), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("4967a4d2-31d2-4a60-9443-9f975dac3c3d"), Type = TextBlockType.Text, Text = "While in Ironblood Stance, you gain resistance 2 to all damage. The resistance increases to 3 at 12th level, to 4 at 16th level, and to 5 at 20th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94a10cd3-b12f-4a31-bdbf-71268128e16f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
