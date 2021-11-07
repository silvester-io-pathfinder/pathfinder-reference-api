using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResilientShell : Template
    {
        public static readonly Guid ID = Guid.Parse("7b3e2306-ee25-47c8-9a83-50c06cead159");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resilient Shell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fae7081-98e0-4e2a-8a54-61f08a4a1b73"), Type = TextBlockType.Text, Text = "Your eidolon is resilient against attacks. It gains resistance to physical damage equal to its Constitution modifier." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8596dc0-ac0f-4ed5-ad59-1314040d8f71"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
