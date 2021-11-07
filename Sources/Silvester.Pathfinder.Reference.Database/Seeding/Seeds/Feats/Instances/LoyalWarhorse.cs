using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoyalWarhorse : Template
    {
        public static readonly Guid ID = Guid.Parse("82182ddd-ba84-494b-a48e-48dedecea34f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loyal Warhorse",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ae9962a-8297-4e1c-9730-d9c991bd377a"), Type = TextBlockType.Text, Text = "You and your mount have grown closer, and your loyalty to each other is unbreakable. The mount you gained through the divine ally class feature is now a mature animal companion (page 214). In addition, your mount never attacks you, even if it is magically compelled to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("d1dc3fed-b96a-495c-a1e2-bde9c9d43b88"), DivineAllies.Instances.Steed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fd3f530-5f0b-4d94-8323-ad58eafdcae5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
