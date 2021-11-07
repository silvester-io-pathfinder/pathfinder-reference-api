using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DestructiveVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("198300b4-e154-48de-afe1-13aed99ba6c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Destructive Vengeance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet damages you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2c6ad5b-d6e4-4763-bbd4-71ec10ed497e"), Type = TextBlockType.Text, Text = "Bloodshed begets bloodshed as you drag your enemy toward oblivion. You increase the amount of damage you take by 1d6, and you deal 1d6 damage to the triggering enemy, choosing evil or negative damage to deal to the enemy each time you use this reaction. In addition, until the end of your next turn, your (action: Strikes | Strike) against the triggering creature deal 2 extra damage of the type you chose." };
            yield return new TextBlock { Id = Guid.Parse("63725ef8-7058-4be7-af00-a5f71606ffb9"), Type = TextBlockType.Text, Text = "The damage you take and deal when you use this reaction increases to 2d6 at 5th level, 3d6 at 9th level, 4d6 at 12th level, 5d6 at 16th level, and 6d6 at 19th level. The extra damage on your (action: Strikes | Strike) increases to 4 at 9th level and 6 at 16th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("895002eb-d5e1-48ef-bda8-56102361fb7d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
