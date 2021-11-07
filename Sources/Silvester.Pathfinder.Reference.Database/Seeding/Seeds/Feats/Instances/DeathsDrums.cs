using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathsDrums : Template
    {
        public static readonly Guid ID = Guid.Parse("8c28150d-317e-40c2-92dc-a5be90bf0831");

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
            yield return new TextBlock { Id = Guid.Parse("f4154979-2cd4-49c4-9e55-9f2e5ebb66e1"), Type = TextBlockType.Text, Text = "Your life has been spent challenging death itself, and proximity to that implacable foe only makes your heart beat harder. When you are taking persistent damage or your wounded value is 1 or greater, you gain a +2 circumstance bonus to Fortitude saving throws." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57b7edb5-959c-4893-a378-298afedcaf50"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
