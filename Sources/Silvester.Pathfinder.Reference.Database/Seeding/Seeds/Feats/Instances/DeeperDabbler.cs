using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeeperDabbler : Template
    {
        public static readonly Guid ID = Guid.Parse("2a70a7a4-03c0-4b3e-b0bc-7f57dc563b7f");

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
            yield return new TextBlock { Id = Guid.Parse("a83554ac-df5a-4dd0-aff7-9d4744039eb0"), Type = TextBlockType.Text, Text = "With some streamlining to your process and a deeper collection of talisman materials, you make a greater number of talismans every day. You can create two additional talismans during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("56b628c5-19ec-45f0-a719-b34b1430ca8f"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83aca96c-915a-4a69-acde-61757599b780"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
