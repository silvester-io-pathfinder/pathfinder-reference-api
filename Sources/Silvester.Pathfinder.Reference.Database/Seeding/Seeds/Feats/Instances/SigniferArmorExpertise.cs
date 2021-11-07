using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SigniferArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("f71f6a4d-bb50-4ccf-b681-cb3f4f8a06e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signifer Armor Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("60aae30e-72dd-48a6-b954-5b536d964e26"), Type = TextBlockType.Text, Text = "You’ve spent enough time helping your comrades equip medium and heavy armor that you spread your own expertise to those armors as well. If you have expert proficiency in any armor or unarmored defense, you also gain expert proficiency in medium and heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2f07309b-8d42-4150-a024-76a2c2d9c625"), Feats.Instances.HellknightSigniferDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4809dd6-bbc2-4f2b-9620-5887170f863c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
