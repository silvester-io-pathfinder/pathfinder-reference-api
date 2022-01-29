using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueTransmogrification : Template
    {
        public static readonly Guid ID = Guid.Parse("2cecb6b8-f368-4e3f-8d38-9e12353a08c3");

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
            yield return new TextBlock { Id = Guid.Parse("3e327619-fe04-451c-8315-7b2ea36bfc5e"), Type = TextBlockType.Text, Text = $"You transmogrify your eidolon each day. During your daily preparations, you can swap out any number of your {ToMarkdownLink<Models.Entities.Trait>("evolution", Traits.Instances.Evolution.ID)} feats, each for a different {ToMarkdownLink<Models.Entities.Trait>("evolution", Traits.Instances.Evolution.ID)} feat of an appropriate level for which you meet the prerequisites. These swaps last until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cd57c89-7f55-45c0-afb8-7273426288b1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
