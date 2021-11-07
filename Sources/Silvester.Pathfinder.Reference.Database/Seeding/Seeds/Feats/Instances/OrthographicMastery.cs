using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrthographicMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("26cc547f-dea4-4133-8213-8068153103be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orthographic Mastery",
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
            yield return new TextBlock { Id = Guid.Parse("f1666a3b-0ff5-4baf-b494-88c65aa7b5e0"), Type = TextBlockType.Text, Text = "You understand the principles that underlie all written words, allowing you to read nearly any text. You can attempt to (action: Decipher Writing) using Loremaster Lore in place of the required skill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("89e90260-0e8c-434b-9175-e7a71f60f64e"), Feats.Instances.LoremasteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d05336b-4e83-4689-ad01-63af0a093e49"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
