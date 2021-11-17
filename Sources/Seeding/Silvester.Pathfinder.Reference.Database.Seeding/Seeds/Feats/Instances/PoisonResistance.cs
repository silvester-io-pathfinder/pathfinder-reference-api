using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("187bd35b-17f0-4511-a0f7-6d52d8ce2921");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poison Resistance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e085efe-6af9-4431-a924-6f0309d795da"), Type = TextBlockType.Text, Text = "Repeated exposure to toxic reagents has fortified your body against poisons of all kinds. You gain poison resistance equal to half your level, and you gain a +1 status bonus to saving throws against poisons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38e758b0-8df7-4652-b83f-c3477197f1b8"), Feats.Instances.AssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebeddf70-ed3c-480d-b3d3-035da82b75db"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
