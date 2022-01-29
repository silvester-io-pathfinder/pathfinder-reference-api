using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TreeClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("d20c92db-26b4-459b-b057-e35f71b7c2f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tree Climber",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68b1aca4-402c-4e03-986f-6e7f7c08352a"), Type = TextBlockType.Text, Text = $"Your time in forest or jungle canopies has taught you how to scramble across branches with sure feet. You gain a climb Speed of 10 feet. If you also have the {ToMarkdownLink<Models.Entities.Feat>("Cave Climber", Feats.Instances.CaveClimber.ID)} ancestry feat, your total climb Speed increases to your land Speed when climbing trees." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("cdee195e-9e51-4e39-927d-7a035fff20f8"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("1759ecae-61d9-4d0f-ac6b-acfdd3186964"), Heritages.Instances.TailedGoblin.ID);
                or.HaveSpecificHeritage(Guid.Parse("5ec619a8-3e7b-4f0a-a1c8-ab19d09f4ea6"), Heritages.Instances.TreedwellerGoblin.ID);
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
                Id = Guid.Parse("c8250ebe-f54e-4d5e-85e2-b73928a49d94"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
