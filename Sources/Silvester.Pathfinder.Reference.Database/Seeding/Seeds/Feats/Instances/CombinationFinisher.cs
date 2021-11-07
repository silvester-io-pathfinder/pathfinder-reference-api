using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombinationFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("8e66ca82-f8d7-4e3e-9061-35f9596c5a19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combination Finisher",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("479c506c-afa1-46fa-b5a0-0224e14a69c4"), Type = TextBlockType.Text, Text = "You combine a series of attacks with a powerful finishing blow. Your (trait: finishers’ | finisher) (action: Strikes | Strike) have a lower multiple attack penalty: -4 (or -3 with an (trait: agile) weapon) if it’s the second attack on your turn, or -8 (or -6 with an (trait: agile) weapon) if it’s the third or subsequent attack on your turn, instead of -5 and -10, respectively." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46a3a7c8-86a0-45ff-a6f1-6c723c7dfcfe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
