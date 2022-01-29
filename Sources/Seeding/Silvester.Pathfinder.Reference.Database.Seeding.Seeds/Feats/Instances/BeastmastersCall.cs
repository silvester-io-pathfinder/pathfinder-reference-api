using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmastersCall : Template
    {
        public static readonly Guid ID = Guid.Parse("057c82ce-7ad8-4000-a868-ed5dc3242ac6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastmaster's Call",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55f047a6-c21c-4b13-a84a-877e00b7fe8b"), Type = TextBlockType.Text, Text = $"You quickly call in a primal projection of a non-active companion to provide the companion's support benefit. The projection arrives in an unoccupied square of your choice within 30 feet of you, grants you its support benefit, and then disappears on your next turn. The projection has the same AC and saving throw modifiers as the real companion, and if it would take any damage before your next turn, it disappears and the support benefit ends immediately." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3140cc76-99f6-4767-bd3a-a2473c577be8"), Feats.Instances.BeastmasterDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("8c3d1fd1-0dba-4406-80d1-43c9e225a20d"), Feats.Instances.CallCompanion.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91873302-712a-4f65-991f-11168bccc9e8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
