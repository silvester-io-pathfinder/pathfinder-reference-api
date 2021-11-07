using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhenomsVerve : Template
    {
        public static readonly Guid ID = Guid.Parse("b6a54d8c-a14b-45ad-a203-3e9cab75b146");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phenom's Verve",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0d54081-aaec-45c5-bd5d-ac85ccd16483"), Type = TextBlockType.Text, Text = "You’re possessed with an incredibly vivacious spark that separates you not only from ordinary gun users and gunslingers, but even from other phenoms. Using that distinctive verve, when you perform impeccably and control the scene with your abilities, you also manage to set up your foes for disaster and ensure they remain in your sights for any follow-up attacks you want to make against them. If you critically succeed at a Performance check for (feat: Pistol Twirl) or a pistol phenom archetype feat, you gain a +1 status bonus to your attack rolls with one-handed firearms and one-handed melee weapons until the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ba2cac8-483b-4c01-b680-8db74ec8a4cf"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae8d6d93-da8e-4ad4-b268-c39952655416"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
