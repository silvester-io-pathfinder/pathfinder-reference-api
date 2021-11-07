using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GenieWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("cab9ef4c-092f-4fb2-a467-3aea9c535189");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genie Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3552558-f88a-419a-9f72-e1f304f1304e"), Type = TextBlockType.Text, Text = "Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in (item: falchions | falchion), (item: ranseurs | ranseur), (item: scimitars | scimitar), (item: tridents | trident), and all (trait: geniekin | Geniekin - Item) weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d160ff9b-8be1-4a81-a121-1b1b63632cb3"), Feats.Instances.GenieWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96ba08d3-c737-419e-b2f3-a2efd5473e65"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
