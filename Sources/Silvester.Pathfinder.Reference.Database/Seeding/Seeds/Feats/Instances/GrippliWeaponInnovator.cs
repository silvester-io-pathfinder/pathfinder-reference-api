using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrippliWeaponInnovator : Template
    {
        public static readonly Guid ID = Guid.Parse("6664f613-0b42-42c9-bf45-54d77cd975e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Weapon Innovator",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27ea200b-8c07-4520-a81e-fd202f1bd764"), Type = TextBlockType.Text, Text = "You’ve learned devious ways to make the most of your grippli weapons. Whenever you critically hit using a (item: blowguns | Blowgun), (item: hatchets | Hatchet), (item: scythes | Scythe), (item: shortbows | Shortbow), (item: composite shortbows | Composite Shortbow), or grippli weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("963412a7-c389-4591-b62b-9882eb660e89"), Feats.Instances.GrippliWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86d332c7-fb04-4844-9d6a-df44e460574d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
