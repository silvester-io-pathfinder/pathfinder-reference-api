using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TemporaryPotions : Template
    {
        public static readonly Guid ID = Guid.Parse("8fba38ab-496c-44bb-b847-7f85d13211a7");

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
            yield return new TextBlock { Id = Guid.Parse("8f31b775-41f8-4f2e-b41d-2b66df737a98"), Type = TextBlockType.Text, Text = "During your daily preparations, you can create a batch of two temporary oils or potions using a formula you know. These items follow the normal rules to (action: Craft) them, except for the time they take, with some additional restrictions. They must both be the same type of oil or potion, and their level must be 6 or more levels lower than your level. Any items you create this way become inert bottles of liquid the next time you make your daily preparations, and any remaining effects of the temporary items end. A temporary oil or potion has no value." };
            yield return new TextBlock { Id = Guid.Parse("c22d297d-e196-4395-bbdb-b900cdb4b657"), Type = TextBlockType.Text, Text = "If you have master proficiency in your tradition’s spell DCs, you can create a batch of three temporary oils or potions during your daily preparations, and if you have legendary proficiency, you can create a batch of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b997a7a8-9aaf-4562-9143-19861118b295"), Feats.Instances.Cauldron.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbe3a814-55e3-4a5f-91b1-f4aa325ba919"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
