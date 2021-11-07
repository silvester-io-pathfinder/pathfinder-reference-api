using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareEidolonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("bd18dee9-a718-4009-86ff-4f6a68da50eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Eidolon Magic",
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
            yield return new TextBlock { Id = Guid.Parse("b9bfc26f-498e-4039-8b11-918dbf349df3"), Type = TextBlockType.Text, Text = "Your eidolon shares innate spells with you. You can cast the innate spells your eidolon gained from (feat: Magical Understudy), (feat: Magical Adept), and (feat: Magical Master). You and your eidolon share the same daily uses of these innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1b6d1d76-7e5c-447a-8204-95f05c62a378"), Feats.Instances.MagicalUnderstudy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2222c061-4d59-44ac-a2d4-05eab33227ef"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
