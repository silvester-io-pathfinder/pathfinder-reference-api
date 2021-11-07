using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cauterize : Template
    {
        public static readonly Guid ID = Guid.Parse("be4cd216-b4de-4183-9451-24d4a8578e90");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cauterize",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c47bcd4-6d41-4afa-b09d-46eb31f8d570"), Type = TextBlockType.Text, Text = "You use the smoking barrel of your firearm to sear shut a bleeding wound. Make a (action: Strike) with your firearm. You then press the heated barrel to the wounds of you or an ally within reach that is taking persistent bleed damage, giving an immediate flat check to end the bleed with the lower DC for particularly effective assistance." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5201948-3052-4de1-8e70-72e1af0692c3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
