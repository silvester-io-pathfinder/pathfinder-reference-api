using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeethingFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("e44228ea-2fb5-4fdc-be18-d746ae457e75");

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
            yield return new TextBlock { Id = Guid.Parse("e0d117aa-62c9-45fc-b509-c0a8f635d865"), Type = TextBlockType.Text, Text = "Your eidolon’s fury boils over into a reckless, out-of-control frenzy. While frenzied, your eidolon is affected by (spell: boost eidolon) and gains temporary Hit Points equal to your level, but it takes a –2 penalty to AC. Your eidolon can’t voluntarily end the frenzy or start another frenzy while in the frenzy. The frenzy lasts for 1 minute, after which it’s fatigued for 1 minute and can’t start another frenzy for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bc9c41b-e539-4b0e-95c2-d25352e9a057"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
