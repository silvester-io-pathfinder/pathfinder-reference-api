using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxeThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("65e246e4-135e-4da1-86dd-9f8c4450b9b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axe Thrower",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5e6ac6c-f07a-4676-bf02-a6c4d48fb619"), Type = TextBlockType.Text, Text = "You have mastered the weight and balance of a variety of axes and can lob them with ease. Any one-handed axe weapon you wield has the (trait: thrown | thrown 10 ft) trait with a range of 10 feet. For axes that already have the (trait: thrown) trait, the range increases by 10 feet. When you critically succeed at an attack roll with a thrown axe weapon, you apply the axe’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a8705ddc-7df0-4d8c-a7f3-8b3f6f7783ef"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6134b474-1760-409d-a95a-5ea1dbf6999d"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
