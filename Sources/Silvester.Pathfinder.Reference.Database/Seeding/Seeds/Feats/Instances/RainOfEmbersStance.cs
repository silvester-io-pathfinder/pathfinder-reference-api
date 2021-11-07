using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainOfEmbersStance : Template
    {
        public static readonly Guid ID = Guid.Parse("887872f4-c849-4f80-9d31-0dca93668270");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain of Embers Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3640c60c-1950-4f83-8547-6c98f6bf17de"), Type = TextBlockType.Text, Text = "You enter the stance of an enraged phoenix, holding your fingers as rigid as deadly talons while moving with quick, flickering gestures that dance with biting flames. The only (action: Strikes | Strike) you can make are fire talon (action: Strikes | Strike). These deal 1d4 fire damage; are in the brawling group; and have the (trait: agile), (trait: finesse), (trait: fire), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("3fb1e78c-b2fb-4422-85a3-f45da4111af1"), Type = TextBlockType.Text, Text = "While in Rain of Embers Stance, you gain a +1 status bonus to AC and fire resistance equal to half your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61a5c5d3-f7c5-4a00-9f7f-423c403530f3"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
