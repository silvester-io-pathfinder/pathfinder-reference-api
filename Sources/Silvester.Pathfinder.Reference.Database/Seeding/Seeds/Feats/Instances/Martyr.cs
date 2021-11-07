using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Martyr : Template
    {
        public static readonly Guid ID = Guid.Parse("5d9a4ae2-c450-49a3-b5cd-22bb8bfae643");

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
            yield return new TextBlock { Id = Guid.Parse("ad46d59b-f3c7-4225-92a6-c11c52e31455"), Type = TextBlockType.Text, Text = "You go to extreme lengths to support your allies, even when it means bringing (spell: harm) to yourself. If your next action is to cast (spell: harm) or (spell: heal) from your healing or harmful font to restore Hit Points to a single ally, you can channel your own vitality along with the spell. You lose 1d8 Hit Points per level of the spell, which can’t be reduced or mitigated in any way, and your ally regains an equal number of Hit Points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("5a7426d4-eee6-4a37-b8c1-55fac552a49e"), ClassFeatures.Clerics.DivineFont.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3ed456f-dce7-4978-acd7-003aaeb7c831"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
