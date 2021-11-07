using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntuitiveCooperation : Template
    {
        public static readonly Guid ID = Guid.Parse("83c8030d-a921-4232-871c-95d051d0e677");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Cooperation",
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
            yield return new TextBlock { Id = Guid.Parse("8a6847f5-dc5c-4a64-a95e-d8c374dcfefc"), Type = TextBlockType.Text, Text = "~ Access: Jaric ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("d7026a5b-bc52-4118-9301-c192dabf6624"), Type = TextBlockType.Text, Text = "You are accustomed to working alongside others, relying on each other to get by. You gain a +2 circumstance bonus to checks to (action: Aid), and your allies gain a +2 circumstance bonus to checks to (action: Aid) you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23dbc0f6-6caa-4ca8-a998-f95f188d3ac6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
