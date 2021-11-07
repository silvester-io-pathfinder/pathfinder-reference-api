using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("4a7ec7c4-9ab3-4709-ae50-b3fc1454f142");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("cdd449a6-d8ea-4396-9bc7-dbf47e701ec3"), Type = TextBlockType.Text, Text = "Your goblin affinity blends with your class training, granting you great skill with goblin weapons. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the dogslicer, horsechopper, and all goblin weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c79a977-2ac4-4199-a15c-7774a6f621af"), Feats.Instances.GoblinWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("743091e3-be74-49fa-8626-6f3888427b61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
