using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TemporaryPotions : Template
    {
        public static readonly Guid ID = Guid.Parse("e42011d0-c1b5-481d-8aa1-28bc8e4c839d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Temporary Potions",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("780a5c68-58f8-4680-9ffd-ded1bbb891ee"), Type = TextBlockType.Text, Text = "During your daily preparations, you can create a batch of two temporary oils or potions using a formula you know. These items follow the normal rules to (action: Craft) them, except for the time they take, with some additional restrictions. They must both be the same type of oil or potion, and their level must be 6 or more levels lower than your level. Any items you create this way become inert bottles of liquid the next time you make your daily preparations, and any remaining effects of the temporary items end. A temporary oil or potion has no value." };
            yield return new TextBlock { Id = Guid.Parse("d3d3ee7c-3008-4398-a0fe-b7fcd6668bcb"), Type = TextBlockType.Text, Text = "If you have master proficiency in your tradition's spell DCs, you can create a batch of three temporary oils or potions during your daily preparations, and if you have legendary proficiency, you can create a batch of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eb5decc2-c9a5-4548-a89a-200b880a6ba1"), Feats.Instances.Cauldron.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60c71015-4499-425f-91cb-d32aeaa90539"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
