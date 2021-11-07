using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CannyAcumenFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("f0599df4-221d-484c-a0f9-32136a594726");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen - Fortitude",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27fe1233-b7fc-4700-ad06-81a8646b3f08"), Type = TextBlockType.Text, Text = "You become an expert in Fortitude saves. At 17th level, you become a master instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c08336c-97e4-47f7-8574-d3a5a65e13fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
