using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedPoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("136b1e3e-526a-44ab-8832-6a41f302a2d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Poison Weapon",
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
            yield return new TextBlock { Id = Guid.Parse("9f01fd69-73f6-45c1-81be-bb15f1fa92ed"), Type = TextBlockType.Text, Text = "You deliver poisons in ways that maximize their harmful effects. When you apply a simple poison with (feat: Poison Weapon), the poison deals 2d4 poison damage instead of 1d4 poison damage. You don’t waste a poison you apply with (feat: Poison Weapon) on a critically failed attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d0b04e61-36b3-4869-9d11-6a37ea4edad0"), Feats.Instances.PoisonWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68949517-73c6-4f24-960c-f7a186932bdf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
