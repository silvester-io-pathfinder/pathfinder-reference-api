using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DestructiveVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("f8cb1766-2637-4f62-85a0-69dcb994ad14");

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
            yield return new TextBlock { Id = Guid.Parse("1f422f3d-1edc-46cf-a415-53a8b28ba4a5"), Type = TextBlockType.Text, Text = "Bloodshed begets bloodshed as you drag your enemy toward oblivion. You increase the amount of damage you take by 1d6, and you deal 1d6 damage to the triggering enemy, choosing evil or negative damage to deal to the enemy each time you use this reaction. In addition, until the end of your next turn, your (action: Strikes | Strike) against the triggering creature deal 2 extra damage of the type you chose." };
            yield return new TextBlock { Id = Guid.Parse("03778163-f8d9-4fd5-933f-95ec706c6f38"), Type = TextBlockType.Text, Text = "The damage you take and deal when you use this reaction increases to 2d6 at 5th level, 3d6 at 9th level, 4d6 at 12th level, 5d6 at 16th level, and 6d6 at 19th level. The extra damage on your (action: Strikes | Strike) increases to 4 at 9th level and 6 at 16th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa4f24de-60ec-4a5a-9d82-17e034864c3b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
