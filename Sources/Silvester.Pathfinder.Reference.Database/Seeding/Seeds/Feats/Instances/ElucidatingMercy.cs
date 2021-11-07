using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElucidatingMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("95284fa6-0153-4924-b7d0-ee1837fdc007");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elucidating Mercy",
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
            yield return new TextBlock { Id = Guid.Parse("95764779-f543-466f-b88a-1e1e04b332da"), Type = TextBlockType.Text, Text = "Your mercy grants clarity to those around you just when they need it most. When you use (feat: Mercy), you can instead attempt a counteract check to remove the confused or stupefied conditions, using the source of that condition to determine the counteract level and DC. If the condition was caused by an ongoing effect and you don’t remove that effect, the condition returns at the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ebedc9d-2389-4c06-b649-64b24184f102"), Feats.Instances.mercy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f26ce71d-34ea-48f2-bec2-3f4f4d4b0aa7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
