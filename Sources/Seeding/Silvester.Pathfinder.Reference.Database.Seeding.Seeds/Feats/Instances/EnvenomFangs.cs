using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvenomFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("130bd479-c790-48dd-9bc9-1f34c90bc17c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Envenom Fangs",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "a number of times per day equal to your level"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdb751b1-2044-460f-a19d-c2fe985e1c07"), Type = TextBlockType.Text, Text = $"You envenom your fangs. If the next fangs {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make before the end of your next turn hits and deals damage, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals an additional 1d6 poison damage. On a critical failure, the poison is wasted as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc61dc8c-d52f-43d8-b00a-2e617b10789b"), Feats.Instances.SharpFangs.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ddaea9b-8a18-4413-a9b5-75a6ce4c8513"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
