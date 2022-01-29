using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareEidolonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("906f5ecc-d4ab-4704-b8e5-badba3f5a685");

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
            yield return new TextBlock { Id = Guid.Parse("7d90d72b-3284-42bf-85e0-1fb90aa77b28"), Type = TextBlockType.Text, Text = $"Your eidolon shares innate spells with you. You can cast the innate spells your eidolon gained from {ToMarkdownLink<Models.Entities.Feat>("Magical Understudy", Feats.Instances.MagicalUnderstudy.ID)}, {ToMarkdownLink<Models.Entities.Feat>("Magical Adept", Feats.Instances.MagicalAdept.ID)}, and {ToMarkdownLink<Models.Entities.Feat>("Magical Master", Feats.Instances.MagicalMaster.ID)}. You and your eidolon share the same daily uses of these innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("290f8e1e-01cd-4cfa-a5e2-4cd11022e3b2"), Feats.Instances.MagicalUnderstudy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a580934-4172-4713-bc2d-b5356db32db9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
