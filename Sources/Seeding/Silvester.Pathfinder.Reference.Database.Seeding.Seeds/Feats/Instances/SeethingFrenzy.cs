using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeethingFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("8357b703-8a29-4f56-beb8-38ea0b5d4c54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seething Frenzy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("268e7bad-46bf-41a6-81c2-c166c8c6bbba"), Type = TextBlockType.Text, Text = $"Your eidolon's fury boils over into a reckless, out-of-control frenzy. While frenzied, your eidolon is affected by {ToMarkdownLink<Models.Entities.Spell>("boost eidolon", Spells.Instances.BoostEidolon.ID)} and gains temporary Hit Points equal to your level, but it takes a –2 penalty to AC. Your eidolon can't voluntarily end the frenzy or start another frenzy while in the frenzy. The frenzy lasts for 1 minute, after which it's fatigued for 1 minute and can't start another frenzy for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f16d561-be33-4f35-b577-5acce113f841"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
