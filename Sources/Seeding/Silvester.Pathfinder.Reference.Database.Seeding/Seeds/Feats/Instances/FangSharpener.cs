using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FangSharpener : Template
    {
        public static readonly Guid ID = Guid.Parse("9a14db95-683b-4500-bb5b-e79fa10eae03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fang Sharpener",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eee1fd3f-b824-4ae3-819e-bde672ca0dd5"), Type = TextBlockType.Text, Text = "You have filed your teeth into jagged points and have an unusually powerful jaw, making your mouth a dangerous weapon. If you're an irongut goblin, you gain a jaws unarmed attack that deals 1d4 piercing damage, and if you're a razortooth goblin, your jaws unarmed attack deals 1d8 piercing damage and loses the finesse trait. Whenever you score a critical hit with your jaws unarmed attack, your target takes 1 persistent bleed damage per weapon damage die." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("45118d32-3eaa-4168-a8bd-744b23f047eb"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("297e8b36-3036-43b0-915f-45ef9c5e897e"), Heritages.Instances.IrongutGoblin.ID);
                or.HaveSpecificHeritage(Guid.Parse("3ecef5ef-1dd9-438b-b3c2-77239035793f"), Heritages.Instances.RazortoothGoblin.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ad58970-6868-4fbb-8768-8899ae8414aa"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
