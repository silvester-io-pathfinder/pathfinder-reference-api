using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareSetter : Template
    {
        public static readonly Guid ID = Guid.Parse("e3b94a0a-bacf-42fc-96a3-fca196595fbe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Setter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea8dfdef-e851-4cad-bd5c-c9b15475e5e5"), Type = TextBlockType.Text, Text = "You are adept at the time-honored kobold art of trap making. You gain the trained proficiency in Crafting. If you were already trained in Crafting, you instead become trained in a skill of your choice. You gain access to all uncommon kobold snares. You gain the (feat: Snare Crafting) feat, though when choosing your formulas for that feat, you can also choose from uncommon kobold snares, as well as common snares." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26849886-dde1-4d83-8ab4-5b56d534febb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
