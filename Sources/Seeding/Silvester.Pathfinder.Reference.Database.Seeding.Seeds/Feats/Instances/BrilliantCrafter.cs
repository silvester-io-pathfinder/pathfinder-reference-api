using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrilliantCrafter : Template
    {
        public static readonly Guid ID = Guid.Parse("c171af00-841e-492d-9939-271572f23bac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brilliant Crafter",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cc310a2-2e5a-4836-9417-7d8fc77852e9"), Type = TextBlockType.Text, Text = $"Your skill at crafting is unparalleled. You become an expert in Crafting. At 7th level you become a master in Crafting, and at 15th level, you become legendary in Crafting and you become an expert in your inventor class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("440af1e4-47ae-4c9d-b46b-c29e3c1e3d7c"), Feats.Instances.InventorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd95b58-ea50-4317-b986-4278fdefec5a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
