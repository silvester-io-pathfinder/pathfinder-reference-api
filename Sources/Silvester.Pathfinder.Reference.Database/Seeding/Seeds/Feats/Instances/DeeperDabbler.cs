using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeeperDabbler : Template
    {
        public static readonly Guid ID = Guid.Parse("64286351-a608-417f-b1dd-52ba37cd0252");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deeper Dabbler",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time if you are 14th level or higher.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14058332-9b1d-4ba0-9011-28cf2471420f"), Type = TextBlockType.Text, Text = "With some streamlining to your process and a deeper collection of talisman materials, you make a greater number of talismans every day. You can create two additional talismans during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("85805273-cdb0-44d9-871b-e5c9f2eeeb86"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56fd7563-4582-4a05-b1ad-8cee6a7e961a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
