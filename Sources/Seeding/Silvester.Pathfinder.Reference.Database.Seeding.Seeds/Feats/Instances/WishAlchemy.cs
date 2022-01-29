using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WishAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("03a55a9a-e23e-4605-9b55-0a993a7e6588");

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
            yield return new TextBlock { Id = Guid.Parse("a790f376-1264-4bdf-9928-76ddecd58ae0"), Type = TextBlockType.Text, Text = $"You have learned Artokus Kirran's most hidden secrets, granting you the ability to create alchemy infused with the power of wishes. Once per day when you use advanced alchemy during your daily preparations, you can spend a batch of infused reagents to create a wish vial containing a single common arcane spell of your choice of 8th level or lower. The spell must have a casting time of no more than 3 actions, no Cost, and must be able to target you. Only you can Activate the wish vial, which takes the same number of {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions as the spell's casting time and grants you the effects of the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7353f9e-7fa2-441c-8998-bb9019487e37"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
