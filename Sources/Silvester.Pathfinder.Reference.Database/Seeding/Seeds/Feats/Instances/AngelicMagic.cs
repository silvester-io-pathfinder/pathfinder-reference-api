using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AngelicMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("8530c1d8-c47c-4750-b845-c3538712606f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Angelic Magic",
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
            yield return new TextBlock { Id = Guid.Parse("4d2d28d4-7667-4e14-9c5a-7d6a3b374a38"), Type = TextBlockType.Text, Text = "You can tap into the magic of angels that runs through your blood. You can cast (spell: humanoid form) and (spell: remove fear) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4506ec66-caf2-4fa6-91a1-a7704e9a206f"), Feats.Instances.Angelkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56ca57d7-7575-4b66-8994-536e51591454"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
