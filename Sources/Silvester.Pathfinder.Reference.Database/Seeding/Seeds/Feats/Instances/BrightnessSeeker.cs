using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrightnessSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("975aa3fd-aa4d-421d-a51b-e77eee0ba72c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brightness Seeker",
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
            yield return new TextBlock { Id = Guid.Parse("cc3f530a-9c8b-4dc7-b1d2-1526b821e73c"), Type = TextBlockType.Text, Text = "Once per day, you can spend 10 minutes studying your surroundings in search of omens related to a particular course of action to cast (spell: augury) as an innate divine spell. Unless the result of the (spell: augury) was “nothing,” you gain the (feat: Call Upon the Brightness) reaction for the next 30 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77ed2370-da9b-439c-9303-e43339341e38"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
