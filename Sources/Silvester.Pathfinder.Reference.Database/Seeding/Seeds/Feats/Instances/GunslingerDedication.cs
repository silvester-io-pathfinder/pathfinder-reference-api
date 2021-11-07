using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GunslingerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1d459728-4ec1-4596-a111-e4b36336e3ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gunslinger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the gunslinger archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47643035-551d-4a35-b068-b92ec6ba99cf"), Type = TextBlockType.Text, Text = "You become trained in simple and martial crossbows and simple and martial firearms. You become trained in gunslinger class DC." };
            yield return new TextBlock { Id = Guid.Parse("3a50141a-2f57-4d4a-adf6-ab50f053c929"), Type = TextBlockType.Text, Text = "Choose a gunslinger way. You become trained in your way’s associated skill; if you were already trained in this skill, you become trained in a skill of your choice. You don’t gain any other abilities from your choice of way." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("7950ae14-ebd2-47d5-a979-6b0998b0ee16"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51436994-efb4-4a04-9b2e-53a8112e83b2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
