using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FangSharpener : Template
    {
        public static readonly Guid ID = Guid.Parse("9a9bd038-1271-4aa9-9a9e-db730f0ea802");

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
            yield return new TextBlock { Id = Guid.Parse("e5362cf1-eb7a-4964-8513-e82aa0ad548e"), Type = TextBlockType.Text, Text = "You have filed your teeth into jagged points and have an unusually powerful jaw, making your mouth a dangerous weapon. If you’re an irongut goblin, you gain a jaws unarmed attack that deals 1d4 piercing damage, and if you’re a razortooth goblin, your jaws unarmed attack deals 1d8 piercing damage and loses the finesse trait. Whenever you score a critical hit with your jaws unarmed attack, your target takes 1 persistent bleed damage per weapon damage die." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("65c879b0-f832-4bc7-81de-e1023e07a270"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("bedfa555-a398-4895-8bd8-506f73a33678"), Heritages.Instances.IrongutGoblin.ID);
                or.HaveSpecificHeritage(Guid.Parse("c8d8fe72-7b9b-4526-81c5-b4a956667d18"), Heritages.Instances.RazortoothGoblin.ID);
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
                Id = Guid.Parse("301a36c9-4864-4fad-b926-c6ab4773ada3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
