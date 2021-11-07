using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmastersCall : Template
    {
        public static readonly Guid ID = Guid.Parse("25338844-eb45-4cef-a50e-f1ffa396ddd6");

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
            yield return new TextBlock { Id = Guid.Parse("d0c36da7-7bb0-4f9e-bd6c-1f854e4b7cf1"), Type = TextBlockType.Text, Text = "You quickly call in a primal projection of a non-active companion to provide the companion’s support benefit. The projection arrives in an unoccupied square of your choice within 30 feet of you, grants you its support benefit, and then disappears on your next turn. The projection has the same AC and saving throw modifiers as the real companion, and if it would take any damage before your next turn, it disappears and the support benefit ends immediately." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bec95aa6-6c2d-4d2c-9258-82fa7e62e11c"), Feats.Instances.BeastmasterDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("d770822c-9995-4e8e-9def-07001c26db6e"), Feats.Instances.CallCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8329f688-bcb6-4f4b-84a5-76dcbd205091"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
