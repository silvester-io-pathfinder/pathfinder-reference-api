using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueTransmogrification : Template
    {
        public static readonly Guid ID = Guid.Parse("6a7f189e-0904-4489-96f8-e4f36870136c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Transmogrification",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fa8e853-653e-4e51-8beb-1e05ebda2ea1"), Type = TextBlockType.Text, Text = "You transmogrify your eidolon each day. During your daily preparations, you can swap out any number of your (trait: evolution) feats, each for a different (trait: evolution) feat of an appropriate level for which you meet the prerequisites. These swaps last until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bdfb57c-15ac-4244-8ff9-0947aedb0fe2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
