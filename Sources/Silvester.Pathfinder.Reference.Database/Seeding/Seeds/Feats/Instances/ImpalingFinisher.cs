using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpalingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("09ca9187-37e0-45ef-b67c-283f54f0dc71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impaling Finisher",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84153278-ce26-4ef2-996a-c198857b6cad"), Type = TextBlockType.Text, Text = "You stab two foes with a single thrust or bash them together with one punch. Make a bludgeoning or piercing melee (action: Strike) and compare the attack roll result against the AC of up to two foes. One foe must be adjacent to you, and the other foe must be adjacent to and directly behind the first foe, in a straight line from your space. Roll damage once and apply it to each creature you hit. An Impaling Finisher counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5dbe3e8-4605-47a2-a46c-52937ae67085"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
