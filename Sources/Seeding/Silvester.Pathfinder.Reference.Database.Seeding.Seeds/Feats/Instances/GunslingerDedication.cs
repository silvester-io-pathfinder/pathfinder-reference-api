using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GunslingerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("cf0ed3af-9968-442b-80cd-24b3bef699d4");

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
            yield return new TextBlock { Id = Guid.Parse("91f3717d-8d55-409c-88cc-2c8620710b20"), Type = TextBlockType.Text, Text = "You become trained in simple and martial crossbows and simple and martial firearms. You become trained in gunslinger class DC." };
            yield return new TextBlock { Id = Guid.Parse("f99e5c98-cc87-4b16-b442-1489f38752b9"), Type = TextBlockType.Text, Text = "Choose a gunslinger way. You become trained in your way's associated skill; if you were already trained in this skill, you become trained in a skill of your choice. You don't gain any other abilities from your choice of way." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("5f8f8ad7-2638-4d5f-a341-7c7cc3acbcf7"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c066b9be-00fe-4910-9aff-2c8b741a0873"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
