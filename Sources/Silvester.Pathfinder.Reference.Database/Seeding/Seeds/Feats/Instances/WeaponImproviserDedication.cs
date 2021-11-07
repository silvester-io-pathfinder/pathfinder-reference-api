using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeaponImproviserDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ad70c2b3-dee2-4183-8e8e-cf2dfd106ba4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weapon Improviser Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the weapon improviser archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("018a7421-8b5e-4216-9d61-f973a3b45658"), Type = TextBlockType.Text, Text = "You don’t take the normal -2 penalty to attack rolls with improvised weapons. Additionally, whenever you gain a class feature that grants you expert or greater proficiency with any weapon, you also gain that proficiency with improvised weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("f2121f48-9c38-4325-afae-7dd8b58e5887"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60acbe9e-e2d8-48ba-a053-1fc23a311cd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
