using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Demolitionist : Template
    {
        public static readonly Guid ID = Guid.Parse("d7bac0e3-4159-49ee-83d6-11d649fdea4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demolitionist",
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
            yield return new TextBlock { Id = Guid.Parse("2972e189-05aa-469f-a277-ef500e04863d"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("49d46470-1ec1-4192-9d3e-99c02b8a03b4"), Type = TextBlockType.Text, Text = "You know how to destroy objects with a well-placed explosion. Whenever you hit with a bomb (action: Strike) against a trap or an unattended object, you ignore the first 5 points of the object’s Hardness." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85aae738-b031-481c-bb9e-008744c0e69f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
