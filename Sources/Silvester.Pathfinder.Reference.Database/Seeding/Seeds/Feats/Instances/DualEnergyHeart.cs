using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualEnergyHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("791c2e23-3662-473d-86cd-767eb583e117");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Energy Heart",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b73e343-22ae-46ec-8001-4fae5202994b"), Type = TextBlockType.Text, Text = "A second energy dwells in your eidolon. Choose an additional energy damage type. Your unarmed attack that deals energy damage gains the (trait: versatile) trait for the second energy damage type, and your eidolon gains resistance to the second type of energy damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ee48ed15-ce46-4808-96ab-84392361ca95"), Feats.Instances.EnergyHeart.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("547889e4-ae09-4356-b594-48c95ad74dca"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
