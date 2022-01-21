using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatchTheDetails : Template
    {
        public static readonly Guid ID = Guid.Parse("9426bd14-6286-4b07-8f47-1eff7d594c06");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catch the Details",
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
            yield return new TextBlock { Id = Guid.Parse("d8b6d563-230d-4ef3-8b06-055a0cb28c4f"), Type = TextBlockType.Text, Text = $"You are quick at recognizing broad details about people and things around you. You are trained in Society and gain the {ToMarkdownLink<Models.Entities.Feat>("Eye for Numbers", Feats.Instances.EyeForNumbers.ID)} skill feat. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c333edee-542c-4faa-a490-c97546e3c411"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
