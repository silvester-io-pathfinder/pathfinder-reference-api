using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SacredKi : Template
    {
        public static readonly Guid ID = Guid.Parse("7e87267b-7114-4661-bbe9-1feb38a15580");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacred Ki",
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
            yield return new TextBlock { Id = Guid.Parse("bb5ac0fc-4418-444d-8423-5dbbe83db851"), Type = TextBlockType.Text, Text = "The power of your faith suffuses your ki. When you select this feat, choose chaos, evil, good, or law. Your choice must match one of your deity’s alignment components." };
            yield return new TextBlock { Id = Guid.Parse("6846e835-9f3a-42e3-b07a-1b74166ef8bf"), Type = TextBlockType.Text, Text = "When you cast the (spell: ki strike) focus spell and damage a creature whose alignment is opposite your chosen alignment, you can choose for the (spell: ki strike) damage to be of the chosen type. Additionally, you can substitute the damage from (spell: ki blast) (or other ki spells that deal force damage, at the GM’s discretion) with damage of your chosen alignment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4e36a3af-fed2-4df0-80e5-e8c052a29415"), Feats.Instances.KiStrike.ID);
            builder.FollowAnyReligion(Guid.Parse("498e0775-edfe-4200-9fd8-4bcb59fa5796"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2626f8b-71d9-4ada-859d-8ddb448a5f09"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
