using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualOnslaught : Template
    {
        public static readonly Guid ID = Guid.Parse("37ace991-2b66-4b4f-8bfb-6c853e6269e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Onslaught",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9da24e83-e179-4fc2-bdd3-84d44c84d93c"), Type = TextBlockType.Text, Text = "When you lash out with both weapons, you leave no room for the target to escape your attack. When you use (feat: Double Slice), if you miss with both (action: Strikes | Strike), choose one of the two weapons and apply the effects of a hit with that weapon. You can’t choose a weapon if your attack roll with that weapon was a critical failure, meaning you still miss entirely if both attack rolls were critical failures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9c1a193f-e7a7-475c-9f5c-b6bcecc2f331"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abe7d7c7-269e-4bc8-9b90-691a9d9f40a8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
