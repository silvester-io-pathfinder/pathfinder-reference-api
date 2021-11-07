using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElaborateFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("98f6c27a-7d8d-48b1-bb3f-a32320d1119b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elaborate Flourish",
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
            yield return new TextBlock { Id = Guid.Parse("5ca6f904-17b8-4d3f-b9b8-95e50e72bdd2"), Type = TextBlockType.Text, Text = "You embellish your spellcasting with entrancing flourishes and grand pronouncements, making it harder to identify or counter. If the next action you use is to (activity: Cast a Spell), creatures with the ability to (activity: Cast that Spell | Cast a Spell) don’t automatically know what the spell is. In addition, creatures that witness your spellcasting take a -2 circumstance penalty to checks to identify the spell with (action: Recall Knowledge) and checks to counteract the spell during its casting (such as with (feat: Counterspell))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a38d673f-fbae-43bf-a937-9955b8af6dad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
