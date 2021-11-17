using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathsDrums : Template
    {
        public static readonly Guid ID = Guid.Parse("8d83bf76-e588-4f97-82fb-2664f0a59815");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Death's Drums",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f029b9a6-4bfc-4050-a1df-84b6dc984bfe"), Type = TextBlockType.Text, Text = "Your life has been spent challenging death itself, and proximity to that implacable foe only makes your heart beat harder. When you are taking persistent damage or your wounded value is 1 or greater, you gain a +2 circumstance bonus to Fortitude saving throws." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de31ce04-19fc-4382-b9a3-d0aaa614968c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
