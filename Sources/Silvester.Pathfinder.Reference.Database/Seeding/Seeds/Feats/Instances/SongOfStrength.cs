using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SongOfStrength : Template
    {
        public static readonly Guid ID = Guid.Parse("256ff1ea-51b7-4a00-9ff4-57b42333779c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Song of Strength",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f1c0594-46e8-47f7-909e-440f01b4fe67"), Type = TextBlockType.Text, Text = "Your performances inspire strength in your allies. You learn the (spell: song of strength) composition cantrip." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("5f29a2dc-3311-4e7b-a2f8-d01b94d40f9b"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0bcfa4a-bf57-49e2-b004-7db5f80fec40"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
