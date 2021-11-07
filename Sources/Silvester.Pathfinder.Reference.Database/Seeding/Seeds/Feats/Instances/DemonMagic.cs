using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("3d92c60c-f032-4927-9d2b-5cb670a13ec0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demon Magic",
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
            yield return new TextBlock { Id = Guid.Parse("21d355df-8832-4b27-95fd-2bf95bd51872"), Type = TextBlockType.Text, Text = "You can channel the power of the Abyss through your heritage, producing terrible tangible effects. You can cast (spell: paranoia) and (spell: shatter) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8a40bf9f-7a78-4062-af43-18e3773ce324"), Feats.Instances.Pitborn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3378298c-af5a-4fb7-baaa-f8229d6da0b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
