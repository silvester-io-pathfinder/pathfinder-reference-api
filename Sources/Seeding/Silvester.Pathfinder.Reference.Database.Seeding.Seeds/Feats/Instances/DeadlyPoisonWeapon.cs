using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyPoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("b88b153d-d20e-4905-b3a7-af3eabeda86f");

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
            yield return new TextBlock { Id = Guid.Parse("cb98efea-6850-4234-857e-8599797d33a8"), Type = TextBlockType.Text, Text = $"~ Access: elite member of the Poison Maker's Guild" };
            yield return new TextBlock { Id = Guid.Parse("422bee14-f500-4c03-a12f-0e6ee1f900b4"), Type = TextBlockType.Text, Text = $"Your poisons are devastatingly potent. When you apply a simple poison with {ToMarkdownLink<Models.Entities.Feat>("Poison Weapon", Feats.Instances.PoisonWeapon.ID)}, the poison deals 4d4 poison damage instead of 1d4 poison damage. When you apply an injury poison to your weapon, the DC to resist that poison increases by 2, to a maximum of your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("37ae1f33-564a-40b1-8a85-c862b502c565"), Feats.Instances.ImprovedPoisonWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e5798d4-21be-474c-aaf2-e2e60c3b56d8"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
