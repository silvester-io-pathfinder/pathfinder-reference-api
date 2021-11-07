using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnomeWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("aa3496ba-9b3e-4844-a631-0d57322b86a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("fd93a2d2-ad3a-47d9-9c8d-4e4c02312e68"), Type = TextBlockType.Text, Text = "Your gnome affinity blends with your class training, granting you great skill with gnome weapons. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the glaive, kukri, and all gnome weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1d361679-2a84-48fb-850c-88f46bce62ce"), Feats.Instances.GnomeWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("858f4d67-3ba1-400f-947b-12826b467e52"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
