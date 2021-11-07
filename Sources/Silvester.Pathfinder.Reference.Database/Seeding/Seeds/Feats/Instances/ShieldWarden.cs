using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("4d7bf26c-a318-414b-a173-1fb611e710bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield Warden",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c88c651f-5aee-49f9-b460-4f3a39481360"), Type = TextBlockType.Text, Text = "You use your shield to protect your allies. When you have a shield raised, you can use your (feat: Shield Block) reaction when an attack is made against an ally adjacent to you. If you do, the shield prevents that ally from taking damage instead of preventing you from taking damage, following the normal rules for (feat: Shield Block)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f9b73e11-6274-4624-aa7e-021fc9a7a11f"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4221570d-ffb6-42e7-93ec-c5bac247b8f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
