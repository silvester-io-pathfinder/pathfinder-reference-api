using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnravelMysteries : Template
    {
        public static readonly Guid ID = Guid.Parse("dcbfcccb-a0f2-4c84-a7b0-938585d8bff5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unravel Mysteries",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01b35800-d7c3-4630-a808-c85f411b03e0"), Type = TextBlockType.Text, Text = "You can understand the true meaning of texts quickly, and even when you get lost or hit a dead end, you aren't discouraged from making further attempts to get to the bottom of things. When you (action: Decipher Writing), you need only half as long as usual (reducing the time from about 1 minute to about half a minute per page), and if you fail, you don't take the usual -2 circumstance penalty to further checks to decipher that text." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDecipherWritingProficiency(Guid.Parse("2728eb99-96a1-48db-8387-e67b7172f352"), Proficiencies.Instances.Master.ID);
            builder.HaveSpecificFeat(Guid.Parse("2a64fd1e-1775-4b8d-a3df-57f71fc11451"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e62b11f3-5fd7-4342-9fe5-b562a7b855db"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
