using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellMetTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("54d276ab-ae4f-4837-849a-2b2cf3dba053");

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
            yield return new TextBlock { Id = Guid.Parse("65daf6ab-4235-4beb-908d-dc3b694f03a6"), Type = TextBlockType.Text, Text = "You have seen people from so many walks of life in your travels that you naturally adopt a pleasant and affable demeanor when meeting others. You are trained in Diplomacy. If you would automatically become trained in Diplomacy (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("82cda2e8-6480-436b-b861-c6e638c56c20"), Type = TextBlockType.Text, Text = "In addition, you gain the (feat: Hobnobber) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b78adc3-71b9-48d3-8a0b-47cf9d85f874"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
