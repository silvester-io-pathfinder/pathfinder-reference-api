using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Catharsis : Template
    {
        public static readonly Guid ID = Guid.Parse("dc7af065-ca71-4e4d-8a5e-5fea0f8a000d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catharsis",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "determined by your catharsis emotion",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b7151ea-93ba-4c44-9a50-d932abd121ba"), Type = TextBlockType.Text, Text = $"You gain the catharsis activation effects listed for your catharsis emotion. You gain that emotion's emotional fervor benefits for 3 rounds. When your emotional fervor ends, you suffer the listed emotional fallout. After using Catharsis, you can't use it again until you use the {ToMarkdownLink<Models.Entities.Feat>("Settle Emotions", Feats.Instances.SettleEmotions.ID)} activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e03cf32-e88c-4ff0-a395-d587bea97fde"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
