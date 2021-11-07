using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtraSquishy : Template
    {
        public static readonly Guid ID = Guid.Parse("d4ab8f57-909b-4946-8953-8216d53dd2e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extra Squishy",
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
            yield return new TextBlock { Id = Guid.Parse("1c4998e1-59cb-4ae3-900a-15b0bef2b790"), Type = TextBlockType.Text, Text = "Your rubbery physique makes it easier for you to wedge yourself into tight spaces and more difficult for your enemies to dislodge you. You become trained in Acrobatics. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice. If you roll a success to (action: Squeeze), you get a critical success instead. While you’re (action: Squeezing | Squeeze), you gain a +4 circumstance bonus to your Fortitude or Reflex DCs against attempts to (action: Shove) you or otherwise move you from your space." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("9a3c4a23-0519-4388-bf2f-0bcc2af0ffb0"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d874066-799c-42aa-aefc-e199c512f90c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
