using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("7b08c6a2-364d-453f-9733-9a3e3557428d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d2d8df5-56dc-43a9-a348-938ff78b0004"), Type = TextBlockType.Text, Text = "You know how to apply debilitations that are particularly troublesome for spellcasters. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("5887c914-c58a-40b6-93ff-2c380bbb537a"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target is stupefied 1." };
            yield return new TextBlock { Id = Guid.Parse("d501284d-27dd-4dfd-bc1c-a42d7c908dd7"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t (action: Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("76ab8939-0fb0-4edd-b1f2-91fd2ffacaed"), Rackets.Instances.EldritchTrickster.ID);
            builder.HaveSpecificFeat(Guid.Parse("cd3ab287-1c27-4ff0-b0b4-d6c5b48cbea0"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab111550-925a-4313-85ad-bf68bfe1d4f0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
