using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Catharsis : Template
    {
        public static readonly Guid ID = Guid.Parse("a86ff2d8-4253-4195-a82a-875ceee5a21c");

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
            yield return new TextBlock { Id = Guid.Parse("0edb2bd6-21b5-4357-b488-85fa2bc6a261"), Type = TextBlockType.Text, Text = "You gain the catharsis activation effects listed for your catharsis emotion. You gain that emotion’s emotional fervor benefits for 3 rounds. When your emotional fervor ends, you suffer the listed emotional fallout. After using Catharsis, you can’t use it again until you use the (feat: Settle Emotions) activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8af781f8-b344-4077-8f93-67121ec990eb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
