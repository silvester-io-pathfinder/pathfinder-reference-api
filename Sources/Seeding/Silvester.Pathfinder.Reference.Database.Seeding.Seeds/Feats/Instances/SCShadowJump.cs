using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SCShadowJump : Template
    {
        public static readonly Guid ID = Guid.Parse("3baac5df-c3ab-40a3-9596-6669bae6a752");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "SC - Shadow Jump",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("473153db-01e1-44a2-8436-d3ae251ebfff"), Type = TextBlockType.Text, Text = $"You learn the {ToMarkdownLink<Models.Entities.Spell>("shadow jump", Spells.Instances.ShadowJump.ID)} shadowdancer focus spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aefa00a3-7fbc-475c-b565-c239877078ac"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
