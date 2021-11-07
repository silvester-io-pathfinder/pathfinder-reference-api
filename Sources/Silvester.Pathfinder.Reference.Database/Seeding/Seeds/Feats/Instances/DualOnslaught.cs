using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualOnslaught : Template
    {
        public static readonly Guid ID = Guid.Parse("5185557c-3c62-4bd9-a8db-c894212c43ae");

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
            yield return new TextBlock { Id = Guid.Parse("bf754879-39d3-4b64-9c54-02bffde0fa0c"), Type = TextBlockType.Text, Text = "When you lash out with both weapons, you leave no room for the target to escape your attack. When you use (feat: Double Slice), if you miss with both (action: Strikes | Strike), choose one of the two weapons and apply the effects of a hit with that weapon. You can’t choose a weapon if your attack roll with that weapon was a critical failure, meaning you still miss entirely if both attack rolls were critical failures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d100713-2ac4-4a86-adaa-e49ec12495f2"), Feats.Instances.DualWeaponDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("120155b4-b9c2-4fcc-bee5-83076a935c1f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
