using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WishAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("acab091e-0773-4dfc-8d51-4b5b1828accc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wish Alchemy",
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
            yield return new TextBlock { Id = Guid.Parse("d23fc178-582e-4578-ab8f-5f6c9b8fc817"), Type = TextBlockType.Text, Text = "You have learned Artokus Kirran’s most hidden secrets, granting you the ability to create alchemy infused with the power of wishes. Once per day when you use advanced alchemy during your daily preparations, you can spend a batch of infused reagents to create a wish vial containing a single common arcane spell of your choice of 8th level or lower. The spell must have a casting time of no more than 3 actions, no Cost, and must be able to target you. Only you can Activate the wish vial, which takes the same number of (action: Interact) actions as the spell’s casting time and grants you the effects of the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a056811b-4168-46e3-8766-e877fa967c6c"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
