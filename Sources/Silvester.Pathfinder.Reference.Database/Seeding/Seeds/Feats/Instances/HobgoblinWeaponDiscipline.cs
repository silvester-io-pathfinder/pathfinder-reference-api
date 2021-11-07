using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HobgoblinWeaponDiscipline : Template
    {
        public static readonly Guid ID = Guid.Parse("d90d08a2-cc8e-4482-8d4a-5ca128e05c9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hobgoblin Weapon Discipline",
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
            yield return new TextBlock { Id = Guid.Parse("5bd8eeab-8397-4d78-ad70-01c4438e42d1"), Type = TextBlockType.Text, Text = "You know how to efficiently utilize the weapons soldiers use in close quarters. Whenever you score a critical hit using a weapon of the polearm, spear, or sword group, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("64bb756e-8d43-4401-b662-77a6c2c9efa3"), Feats.Instances.HobgoblinWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6daa87f5-f48e-41d1-81ab-0f2e81ecc9ca"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
