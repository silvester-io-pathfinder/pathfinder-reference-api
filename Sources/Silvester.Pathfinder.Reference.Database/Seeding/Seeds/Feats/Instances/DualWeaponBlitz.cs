using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualWeaponBlitz : Template
    {
        public static readonly Guid ID = Guid.Parse("58216e25-46fa-4055-b3de-26c4a3aaa7fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Weapon Blitz",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b49dc75-9c43-442a-a4d4-f8acf96ef615"), Type = TextBlockType.Text, Text = "You attack as you dash among foes. (action: Stride) up to your Speed. At any point during this movement, you can (action: Strike) once with each of the two required weapons. These (action: Strikes | Strike) can be against the same or different targets, as you see fit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("23adce6c-b11f-4801-85c4-2adbb3b2cac1"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0ffb5df-af49-414e-a49d-53321f2b9503"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
