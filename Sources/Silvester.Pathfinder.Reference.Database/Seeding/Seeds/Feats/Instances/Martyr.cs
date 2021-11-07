using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Martyr : Template
    {
        public static readonly Guid ID = Guid.Parse("9621ffd4-a6a3-4c1c-bf49-e04d571483c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martyr",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09c7cf16-f301-4ead-ad9d-52874e28724b"), Type = TextBlockType.Text, Text = "You go to extreme lengths to support your allies, even when it means bringing (spell: harm) to yourself. If your next action is to cast (spell: harm) or (spell: heal) from your healing or harmful font to restore Hit Points to a single ally, you can channel your own vitality along with the spell. You lose 1d8 Hit Points per level of the spell, which can’t be reduced or mitigated in any way, and your ally regains an equal number of Hit Points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("528b1fda-4598-409c-b65f-17d6fff0f06c"), ClassFeatures.Clerics.DivineFont.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c46ea85-00e2-4e57-9f65-a107c42b5e2a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
