using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellMetTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("42ea915b-0d9c-4533-80ab-0002f688451b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Well-Met Traveler",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bcce4cd-d762-4280-92cf-b4f8fbd0b33c"), Type = TextBlockType.Text, Text = "You have seen people from so many walks of life in your travels that you naturally adopt a pleasant and affable demeanor when meeting others. You are trained in Diplomacy. If you would automatically become trained in Diplomacy (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("892d9e54-e369-4b3d-8278-aea9844a24d0"), Type = TextBlockType.Text, Text = "In addition, you gain the (feat: Hobnobber) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("929f36c3-acd1-4581-9aef-707ad7452da7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
