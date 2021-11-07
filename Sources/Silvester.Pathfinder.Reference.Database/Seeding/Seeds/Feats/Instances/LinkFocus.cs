using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LinkFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("cfc678b7-410e-48ed-9dae-3947f74ac641");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Link Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c1add4a-f72f-4ba2-9cbd-c5d06829af3c"), Type = TextBlockType.Text, Text = "Your focus recovers faster. If you have spent at least 2 Focus Points since the last time you (action: Refocused | Refocus), you recover 2 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("36704928-8edb-4b4e-b75c-40043efccd1f"), ClassFeatures.Summoners.LinkSpells.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71dcfa90-a2d0-4004-a56f-c7775f6953cf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
