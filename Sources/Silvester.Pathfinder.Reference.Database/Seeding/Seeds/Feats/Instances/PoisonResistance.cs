using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("34489b4a-676a-4cd7-b3f6-af70cbbbb0f2");

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
            yield return new TextBlock { Id = Guid.Parse("b26313bd-90e4-4adb-aa2b-dc6c13671dd6"), Type = TextBlockType.Text, Text = "Repeated exposure to toxic reagents has fortified your body against poisons of all kinds. You gain poison resistance equal to half your level, and you gain a +1 status bonus to saving throws against poisons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("215da74a-3a72-4aa2-b686-34f9dfb6f58f"), Feats.Instances.AssasinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9572557-31b7-4819-925b-891e8b1284ac"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
