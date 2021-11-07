using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyPoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("4c764bf2-4d1c-4e46-bc2f-6acb5049b4e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Poison Weapon",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c25ec28f-f71d-480e-bca6-c38ae7e13a96"), Type = TextBlockType.Text, Text = "~ Access: elite member of the Poison Maker’s Guild" };
            yield return new TextBlock { Id = Guid.Parse("b081b235-f3ef-4cce-a5ab-dd6103f97c76"), Type = TextBlockType.Text, Text = "Your poisons are devastatingly potent. When you apply a simple poison with (feat: Poison Weapon), the poison deals 4d4 poison damage instead of 1d4 poison damage. When you apply an injury poison to your weapon, the DC to resist that poison increases by 2, to a maximum of your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ec48de2-8f3b-49ad-955a-e2f592083b7b"), Feats.Instances.ImprovedPoisonWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cefab2e9-3446-48fd-98e3-dedf7fd525a7"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
