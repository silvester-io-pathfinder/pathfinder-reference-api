using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfSunsGift : Template
    {
        public static readonly Guid ID = Guid.Parse("4d01cc72-ef74-4a1b-aeeb-eca64c573422");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of Sun's Gift",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb934426-1894-47b2-858e-f37a0661eb66"), Type = TextBlockType.Text, Text = "Your connection to the sun has become an unbreakable bond. You don’t become temporarily immune to the effects of your Sunlight Healing, and instead of rolling to recover Hit Points, you gain the maximum number of HP possible (for example, 64 HP instead of 8d8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a76432f-938e-4856-ba26-5fd719ef6505"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
