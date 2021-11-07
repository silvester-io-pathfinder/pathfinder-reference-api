using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousIncisors : Template
    {
        public static readonly Guid ID = Guid.Parse("d654597f-f3e1-4203-bc92-a8963209bca3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Incisors",
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
            yield return new TextBlock { Id = Guid.Parse("6974e318-f9f7-4bbe-8e09-35da919529c3"), Type = TextBlockType.Text, Text = "You&#39;ve let your incisors grow long enough to serve as formidable weapons. You gain a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group and have the (trait: finesse) and (trait: unarmed) traits. Unlike most creatures, you can file down your teeth and regrow them later on, enabling you to select this feat at any level, and to retrain into and out of this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18dcee2f-1439-43d5-a4c5-a837bc6d1fd1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
