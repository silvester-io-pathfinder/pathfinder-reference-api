using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Bay : Template
    {
        public static readonly Guid ID = Guid.Parse("8313874c-9652-486f-8edf-f2285397226f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bay",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c02d273-6885-4eeb-809c-7ac78a586ca7"), Type = TextBlockType.Text, Text = "The shadow hound releases an eerie bay, attempting to (action: Demoralize) each foe in a 20-foot emanation. These (action: Demoralize) attempts don’t require a language and don’t take any penalty due to not sharing a language." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db3d670f-e18d-4e7f-8d41-07e93b8fbe66"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
