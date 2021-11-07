using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfAeonsGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("52eebea8-ecc5-43d0-98f6-716f4846edbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of Aeon's Guidance",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eeedc053-a2ff-469f-a69a-dcc9ef70f6ba"), Type = TextBlockType.Text, Text = "Your patron aeon has allowed you to call upon their gifts to serve their ends. You can cast (spell: augury) and (spell: calm emotions) each once per day as 2nd-level divine innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b791ab8-ab36-4ff6-9286-c30d833eba2b"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
